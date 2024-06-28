using AirportLockerRental.UI.DTOs;

namespace AirportLockerRental.UI.Actions
{
    public class LockerManager
    {
        private LockerContents[] _lockers = new LockerContents[100];

        public void ListContents()
        {
            for (int i = 0; i < _lockers.Length; i++)
            {
                if (_lockers[i] != null)
                {
                    DisplayLockerContents(i + 1);
                }
            }
        }

        public void DisplayLockerContents(int lockerNumber)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Locker #: {lockerNumber}");
            Console.WriteLine($"Renter Name: {_lockers[lockerNumber - 1].RenterName}");
            Console.WriteLine($"Contents: {_lockers[lockerNumber - 1].Description}");
            Console.WriteLine("=====================================");
        }

        public LockerStatus ViewLocker(int lockerNumber)
        {
            if (_lockers[lockerNumber-1] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is EMPTY");
                return LockerStatus.Empty;
            }
            else
            {
                DisplayLockerContents(lockerNumber);
                return LockerStatus.Rented;
            }
        }

        public RentResult RentLocker(int number)
        {
            // is the locker already rented?
            if (_lockers[number-1] != null)
            {
                Console.WriteLine($"Sorry, but locker {number} has already been rented!");
                return RentResult.Failure;
            }
            else
            {
                LockerContents contents = new LockerContents();
                _lockers[number - 1] = contents;
                return RentResult.Success;
            }
        }

        public void RegisterLocker(int lockerNumber)
        {

            _lockers[lockerNumber - 1].RenterName = ConsoleIO.GetRequiredString("Enter your name: ");
            _lockers[lockerNumber - 1].Description = ConsoleIO.GetRequiredString("Enter the item you want to store in the locker: ");
        }

        public RentResult EndRental(int lockerNumber)
        {
            if (_lockers[lockerNumber-1] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is not currently rented.");
                return RentResult.Failure;
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} rental has ended, please take your {_lockers[lockerNumber-1].Description}.");
                _lockers[lockerNumber-1] = null;
                return RentResult.Success;
            }
        }
    }
}
