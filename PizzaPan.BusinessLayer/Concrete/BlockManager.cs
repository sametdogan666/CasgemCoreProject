using System.Collections.Generic;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class BlockManager : IBlockService
    {
        private readonly IBlockDal _blockDal;

        public BlockManager(IBlockDal blockDal)
        {
            _blockDal = blockDal;
        }

        public void TInsert(Block entity)
        {
            _blockDal.Insert(entity);
        }

        public void TUpdate(Block entity)
        {
            _blockDal.Update(entity);
        }

        public void TDelete(Block entity)
        {
            _blockDal.Delete(entity);
        }

        public List<Block> TGetList()
        {
            return _blockDal.GetList();
        }

        public Block TGetById(int id)
        {
            return _blockDal.GetById(id);
        }
    }
}