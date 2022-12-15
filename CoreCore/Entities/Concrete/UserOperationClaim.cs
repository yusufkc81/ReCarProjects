using Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim:ICar
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }

}
