namespace EasyMoto.Application.DTOs.Response
{
    public class CreatedMotoResponse
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Status { get; set; }
        public int FilialId { get; set; }
    }
}