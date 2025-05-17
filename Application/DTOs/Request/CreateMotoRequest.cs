namespace EasyMoto.Application.DTOs.Request
{
    public class CreateMotoRequest
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Status { get; set; }
        public int FilialId { get; set; }
    }
}