namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Reservation
{
    private readonly List<Reservation> _reserv = new();
    private readonly DateTime checkInDate;
    private readonly DateTime checkOutDate;
    private readonly Guest guest;
    private readonly int reservationId;
    private readonly Room room;

    public Reservation(int reservationId, Room room, DateTime checkInDate, DateTime checkOutDate, Guest guest)
    {
        this.reservationId = reservationId;
        this.room = room;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
        this.guest = guest;
    }

    public void AddReservation(Reservation reservation)
    {
        var newReserv = new Reservation(reservationId, room, checkInDate, checkOutDate, guest);
        _reserv.Add(newReserv);
    }

    public void RemoveReservation(Reservation reservation)
    {
        _reserv.Remove(this);
    }
}