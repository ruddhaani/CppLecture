using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_details
{
    public class RoomServices
    {
        public string PaintingService()
        {
            return "paint";
        }

        private string CleaningService()
        {
            return "clean";
        } 
        public string Services()
        {
            return CleaningService();
        }

    }
}
