
using CampusPlacementManagement.Models.Enums;

namespace CampusPlacementManagement.Models;

public class College
{
    public int Id { get; set; }

    public string CollegeName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string? Website { get; set; }

    public CollegeStatus Status { get; set; } = CollegeStatus.Pending;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}
