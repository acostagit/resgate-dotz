using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Services
{
    public class PedidoService : ServicoBase<Pedido>, IPedidoRepository
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
            :base(pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }
        //public Task Add(Pedido entity)
        //{
        //    return _pedidoRepository.Add(entity);
        //}

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<List<Pedido>> GetAll()
        //{
        //    return await _pedidoRepository.GetAll();
        //}

        //public async Task<Pedido> GetById(int id)
        //{
        //    return await _pedidoRepository.GetById(id);
        //}

        //public async Task Remove(int id)
        //{
        //    await _pedidoRepository.Remove(id);
        //}

        //public async Task Update(Pedido entity)
        //{
        //    await _pedidoRepository.Update(entity);
        //}
    }
}
