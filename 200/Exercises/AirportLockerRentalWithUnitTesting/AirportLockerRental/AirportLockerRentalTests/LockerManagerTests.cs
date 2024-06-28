using NUnit.Framework;
using AirportLockerRental.UI.Actions;



namespace AirportLockerRentalTests
{
    [TestFixture]
    public class LockerManagerTests
    {
        [TestCase(1, LockerStatus.Empty)]
        [TestCase(2, LockerStatus.Empty)]
        public void ViewLocker_EmptyLocker(int number, LockerStatus expected)
        {
            LockerManager lockerManager = new LockerManager();

            var viewLockerResult = lockerManager.ViewLocker(number);

            Assert.AreEqual(expected, viewLockerResult);
        }

        [TestCase(1, LockerStatus.Rented)]
        [TestCase(2, LockerStatus.Rented)]
        public void ViewLocker_RentedLocker(int number, LockerStatus expected)
        {
            LockerManager lockerManager = new LockerManager();

            lockerManager.RentLocker(number);

            var viewLockerResult = lockerManager.ViewLocker(number);

            Assert.AreEqual(expected, viewLockerResult);
        }

        [TestCase(1, RentResult.Success)]
        public void RentLocker_RentSuccess(int number, RentResult expected)
        {
            LockerManager lockerManager = new LockerManager();

            var rentLockerResult = lockerManager.RentLocker(number);

            Assert.AreEqual(expected, rentLockerResult);
        }

        [TestCase(1, RentResult.Failure)]
        public void RentLocker_RentFailure(int number, RentResult expected)
        {
            LockerManager lockerManager = new LockerManager();

            lockerManager.RentLocker(number);

            var rentLockerResult = lockerManager.RentLocker(number);

            Assert.AreEqual(expected, rentLockerResult);
        }

        [TestCase(1, RentResult.Failure)]
        [TestCase(2, RentResult.Failure)]
        public void EndRental_EndFailure(int number, RentResult expected)
        {
            LockerManager lockerManager = new LockerManager();

            var endRentalResult = lockerManager.EndRental(number);

            Assert.AreEqual(expected, endRentalResult);
        }

        [TestCase(1, RentResult.Success)]
        [TestCase(2, RentResult.Success)]
        public void EndRental_EndSuccess(int number, RentResult expected)
        {
            LockerManager lockerManager = new LockerManager();

            lockerManager.RentLocker(number);

            var endRentalResult = lockerManager.EndRental(number);

            Assert.AreEqual(expected, endRentalResult);
        }
    }
}
