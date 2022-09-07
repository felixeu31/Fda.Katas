using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordValidation.Model;
using PasswordValidation.Validations;

namespace PasswordValidation.Factories
{
    public class PasswordValidatorBuilder
    {
        private readonly List<IValidation> _validations;

        public PasswordValidatorBuilder()
        {
            _validations = new List<IValidation>();
        }

        public PasswordValidatorBuilder WithLowerCaseValidation()
        {
            _validations.Add(new LowerCaseValidation());

            return this;
        }

        public PasswordValidatorBuilder WithUpperCaseValidation()
        {
            _validations.Add(new UpperCaseValidation());

            return this;
        }

        public PasswordValidatorBuilder WithNumberCaseValidation()
        {
            _validations.Add(new NumberCaseValidation());

            return this;
        }

        public PasswordValidatorBuilder WithUnderScoreCaseValidation()
        {
            _validations.Add(new UnderScoreCaseValidation());

            return this;
        }

        public PasswordValidatorBuilder WithMinimumCharacterValidation(int number)
        {
            _validations.Add(new MinimumCharacterValidation(number));

            return this;
        }

        public PasswordValidator Build()
        {
            return new PasswordValidator(_validations);
        }
    }
}
