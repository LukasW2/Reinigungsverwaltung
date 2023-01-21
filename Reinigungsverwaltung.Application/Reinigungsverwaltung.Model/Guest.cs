namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Guest
{
    public Guest(int guestId, string name, string address, Reservation reservation)
{
    this.GuestId = guestId;
    this.Name = name;
    this.Address = address;
    this.Reservation = reservation;
}

public int GuestId { get; set; }
public string Name { get; set; }
public string Address { get; set; }
public Reservation Reservation { get; set; }

}