using System;
using EventFlow.Commands;
using RestAirline.Domain.Booking;

namespace RestAirline.CommandHandlers.Passenger
{
    public class AddPassengerCommand : Command<Booking, BookingId>
    {
        public string Name { get; set; }

        public PassengerType PassengerType { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
        
        [Obsolete("For serialization")]
        public AddPassengerCommand() : base(BookingId.Empty())
        {
        }

        public AddPassengerCommand(BookingId aggregateId)  : base(aggregateId)
        {
        }
    }
}