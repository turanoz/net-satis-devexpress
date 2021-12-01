using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using FluentValidation.Results;
using NetSatis.Entities.Interfaces;

namespace NetSatis.Entities.Tools
{
    public static class ValidatorTool
    {
        public static bool Validate(IValidator validator, IEntity entity)
        {
            bool result = true;

            var validationResult = validator.Validate(entity);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var err in validationResult.Errors)
                {
                    message += err.ErrorMessage+System.Environment.NewLine;
                }

                MessageBox.Show(message);
                result = false;
            }


            return result;
        }
    }
}
