using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab1
{
    internal class Garage 
    {
        private Car[]? _cars;
        private string _address;
        private int _carsCount =0;
        private int _capacity;
        public int Capacity {  
            get { return _capacity; }
            set { 
                _capacity = value;
                _cars = new Car[value];
            }
        }  
        public string Address 
        { 
        get { return _address; }
            set { _address = value; }
        }
        public Garage() 
        {
            _cars = null;
            _address = "nieznany";
            _capacity = 0;
        }
        public Garage(string address, int capacity)
        {
          
            _address = address;
            _capacity = capacity;
            _cars = new Car[_capacity];
        }
        public void CarIn(Car car) 
        {
            if (Capacity == _carsCount)
            {
                Console.WriteLine("Garage is full");
            }
            else if (_cars != null)
            {
                
                _cars[_carsCount] = car;
                _carsCount++;
                   
                        

            }
               
        }
        public Car? CarOut() 
        {
            if (_cars == null)
            {
                Console.WriteLine("nie ma garazu");
            
            }
            else if (_carsCount == 0)
            {
                Console.WriteLine("nie ma aut :(");
            
            }
            else if (_carsCount<=Capacity)
            {
                _carsCount--;
                return _cars[_carsCount];
            }
            return null;
        }
        public override string ToString()
        {
            if (_cars != null)
            { return "nie ma"; }
            else
            {
                foreach (var item in _cars)
                {
                    return item.ToString();
                }
                return "hej";
            }

        }
        public void Details() 
        {
          Console.WriteLine(this.ToString());
        }

    }
        
   }
