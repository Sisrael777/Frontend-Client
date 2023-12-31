﻿using VideoDa.ClienteBlazor.Models;

namespace VideoDa.ClienteBlazor.Services
{
    public interface IArticuloServices
    {
        Task<IEnumerable<Articulo>> GetAll();
        Task<Articulo> GetById(int id);
    }
}
