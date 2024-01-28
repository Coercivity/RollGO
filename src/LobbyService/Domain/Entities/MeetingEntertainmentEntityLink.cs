namespace Domain.Entities;

public record MeetingEntertainmentEntityLink : EntityBase
{
    public required Meeting Meeting { get; set; }
    public required EntertainmentEntity EntertainmentEntity { get; set; }
    public Guid UserId { get; set; }
    public required User User { get; set; }
}
