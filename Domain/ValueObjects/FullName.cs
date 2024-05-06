using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Validators;

namespace Domain.ValueObjects
{
    /// <summary>
    /// Класс ФИО
    /// </summary>
    public class FullName : BaseValueObject
    {
        /// <summary>
        /// Конструктор фамилия, имя, отчество
        /// </summary>
        /// <param name="firstName">Иия</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="middleName">Отчество (второе имя)</param>
        public FullName(string firstName, string lastName, string? middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            
            var validator = new FullNameValidator();
            validator.Validate(this);
        }
        /// <summary>
        /// Имя
        /// </summary>
        public  string FirstName {  get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public  string LastName { get; set; }

        /// <summary>
        /// Отчество (второе имя)
        /// </summary>
        public string? MiddleName { get; set; } = null;
    }
}