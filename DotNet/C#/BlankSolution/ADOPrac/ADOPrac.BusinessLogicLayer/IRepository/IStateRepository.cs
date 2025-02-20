using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPrac.BusinessLogicLayer.Models;

namespace ADOPrac.BusinessLogicLayer.IRepository
{
    public interface IStateRepository
    {
        public int Create(State state);

        public int Delete(int id);

        public int Update(State state);

        public StateListResponse GetStateById(int id);

        public int ChangeIsActive(int id, int flag);

        public List<StateListResponse> GetStatesList();
    }
}
