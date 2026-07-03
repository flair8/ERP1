namespace ERP1.Models
{
    public class Result
    {
        private readonly List<Notification> _errors = new();

        public bool IsSuccess => !_errors.Any();

        public IReadOnlyCollection<Notification> Errors => _errors;

        public static Result Success()
        => new();

        public static Result Failure(string property, string message)
        {
            var result = new Result();
            result.AddError(property, message);
            return result;
        }

        public void AddError(string property, string message)
        {
            _errors.Add(new Notification(property, message));
        }

        public void AddError(Notification notification)
        {
            _errors.Add(notification);
        }
    }
}
