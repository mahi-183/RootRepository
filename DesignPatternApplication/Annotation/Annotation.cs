// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Annotation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.Annotation
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// AnnotationClass as class
    /// </summary>
    public class Annotation
    {
        /// <summary>
        /// AnnotationFunction as function
        /// </summary>
        public static void AnnotationFunction()
        {
            try
            {
                //// create Instance of Studentclass.
                Student student = new Student();
                student.Id = 1;
                student.Name = "Swati";
                student.Address = "Pune";

                var details = new ValidationContext(student, null, null);
                var result = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(student, details, result, true);

                //// Used foreach to access to data in result.
                foreach (var item in result)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
