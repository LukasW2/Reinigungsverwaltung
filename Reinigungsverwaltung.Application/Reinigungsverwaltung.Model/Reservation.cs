namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Reservation {
    private int reservationId;
    private Room room;
    private DateTime checkInDate;
    private DateTime checkOutDate;
    private Guest guest;

    public Reservation(int reservationId, Room room, DateTime checkInDate, DateTime checkOutDate, Guest guest) {
        this.reservationId = reservationId;
        this.room = room;
        this.checkInDate = checkInDate;
        this.checkOutDate = checkOutDate;
        this.guest = guest;
    }
    
    List<Reservation> _reserv = new List<Reservation>();
    
    public void AddReservation(Reservation reservation)
    {
        Reservation newReserv = new Reservation(reservationId, room, checkInDate, checkOutDate, guest);
        _reserv.Add(newReserv);
    }

    public void RemoveReservation(Reservation reservation)
    {
        _reserv.Remove(this);
    }
    
    
    
}