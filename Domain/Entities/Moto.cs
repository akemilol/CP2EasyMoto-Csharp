﻿namespace EasyMoto.Domain.Entities
{
    public class Moto
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Status { get; set; }
        public int FilialId { get; set; }
        public Filial Filial { get; set; }
    }
}