using FluentValidation;

namespace BlazoredRepairs.Shared
{
    public class RepairModel
    {
        public string Name { get; set; }
        public string Issue { get; set; }
        public string Trade { get; set; }
        public string ContactNumber { get; set; }
        public bool Complete { get; set; }
    }

    public class RepairModelValidator : AbstractValidator<RepairModel>
    {
        public RepairModelValidator()
        {
            RuleFor(_ => _.Name).NotEmpty().WithMessage("Please enter a name");
            RuleFor(_ => _.Issue).NotEmpty().WithMessage("Please enter the issue");
            RuleFor(_ => _.Issue).MinimumLength(10).WithMessage("Please enter at least 10 characters");
            RuleFor(_ => _.Trade).NotEmpty().WithMessage("Please select a trade");
            RuleFor(_ => _.ContactNumber).NotEmpty().WithMessage("Please enter a contact number");
            RuleFor(_ => _.ContactNumber).Matches(@"^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$").WithMessage("The contact number is not valid");
        }
    }
}