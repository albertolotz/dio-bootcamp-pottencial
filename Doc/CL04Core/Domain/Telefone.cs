namespace CL04Core.Domain
{
    public class Telefone
    {
        //public int Id { get; set; }// --> ID Apagado para utilizar chave composta.
        public int ClienteId { get; set; }
        public string Numero { get; set; }
        public Cliente Cliente { get; set; }
    }
}