using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL03Data.Context;
using CL04Core.Domain;
using Doc.CL02Manager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Doc.CL03Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClContext _context;
        public ClienteRepository(ClContext context) => _context = context;

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _context.Clientes
                .Include(p=>p.Endereco) 
                .AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClientesAsync(int id)
        {
            // op1: return await _context.Clientes.Where(c => c.Id == id).FirstOrDefaultAsync();
            // op2:return await _context.Clientes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
            // op2:return await _context.Clientes.AsNoTracking().SingleOrDefaultAsync(c => c.Id == id);
            return await _context.Clientes
                .Include(p=>p.Endereco)
                .SingleOrDefaultAsync(p=> p.Id == id); // mais indicado devido a permance e ser PK a busca
        }

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var clienteConsultado = await _context.Clientes.FindAsync(cliente.Id);
            if(clienteConsultado == null)
            {
                return null;
            }

            //clienteConsultado.Nome = cliente.Nome;
            //clienteConsultado.DataNascimento = cliente.DataNascimento;
            //linha abaixo substitue as linhas acima 
            _context.Entry(clienteConsultado).CurrentValues.SetValues(cliente);
            //linha não precisa ser utilizada pois o status de cliente consultado já mudou...
            //_context.Update(clienteConsultado);
            await _context.SaveChangesAsync();
            return clienteConsultado;
        }

        public async Task DeleteClienteAsync(int id)
        {
            var clienteConsultado = await _context.Clientes.FindAsync(id);
            _context.Remove(clienteConsultado);
            await _context.SaveChangesAsync();
        }

    }
}