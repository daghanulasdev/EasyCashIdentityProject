using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentityProject.PresentationLayer.Models
{
	public class CustomerIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola en az {length} karakter olmalidir"
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Lutfen en az 1 buyuk harf giriniz."
			};
		}
		public override IdentityError PasswordRequiresLower() 
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Lutfen en az 1 kucuk harf giriniz."
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = "Lutfen en az 1 rakam giriniz."
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Lutfen en az bir sembol giriniz."
			};
		}
	}
}
