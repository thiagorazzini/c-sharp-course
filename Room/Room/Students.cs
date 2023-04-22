using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room
{
    internal class Students
    {
        //São 10  quartos de 0 a 9
        public string Name { get; set; }
        public string Email { get; set; }
        public int[] QtRoom { get; set; }
        public int RoomId { get; set; }

        public Students(int qtRoom)
        {
            QtRoom[] = qtRoom;
        }
    }
}
