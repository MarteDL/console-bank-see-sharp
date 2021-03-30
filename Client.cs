using System;

namespace console_bank_see_sharp
{
    public class Client
    {
        public Client(int id, string name, DateTime joiningDate)
        {
            this.Id = id;
            this.Name = name;
            this.JoiningDate = joiningDate;
        }

        public int Id { get; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; }
    }
}