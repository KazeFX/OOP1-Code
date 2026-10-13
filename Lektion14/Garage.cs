// class Garage
// {
//     private int _capacity;
//     public int Capacity
//     {
//         get
//         {
//             return _capacity;
//         }
//         set
//         {
//             if (value == 0 || value < 0)
//             {
//                 _capacity = 1;
//             }
//             else
//             {
//                 _capacity = value;
//             }
//         }
//     }

//     public int ParkedCars { get; set; }

//     public Garage(int capacity)
//     {
//         Capacity = capacity;
//     }

//     public void FreeLots()
//     {
//         Console.WriteLine($"{Capacity - ParkedCars} free lots");
//     }

//     public void ParkCar()
//     {
//         if (ParkedCars != Capacity)
//         {
//             ParkedCars++;
//         }
//     }

//     public void RemoveCar()
//     {
//         if (ParkedCars > 0)
//         {
//             ParkedCars--;
//         }
//     }
// }