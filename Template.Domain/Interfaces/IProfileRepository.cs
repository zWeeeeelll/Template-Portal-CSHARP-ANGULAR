using Template.Domain.Entities.Usr;

namespace Template.Domain.Interfaces
{
    public interface IProfileRepository
	{
		Profile GetDefault();
	}
}
