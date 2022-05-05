﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Course_Registration
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Student.
    /// </summary>
    // *** Start programmer edit section *** (Student CustomAttributes)

    // *** End programmer edit section *** (Student CustomAttributes)
    [AutoAltered()]
    [Caption("Student Registration")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("StudentE", new string[] {
            "Name as \'Name\'",
            "Surname as \'Surname\'",
            "BirthDate as \'Birth date\'",
            "Email as \'Email\'",
            "Gender as \'Gender\'",
            "Course as \'Course\'",
            "Course.Name as \'Name\'"}, Hidden=new string[] {
            "Course.Name"})]
    [MasterViewDefineAttribute("StudentE", "Course", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("StudentL", new string[] {
            "Name as \'Name\'",
            "Surname as \'Surname\'",
            "BirthDate as \'Birth date\'",
            "Email as \'Email\'",
            "Gender as \'Gender\'",
            "Course.Name as \'Name\'"})]
    public class Student : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private string fSurname;
        
        private System.DateTime fBirthDate;
        
        private string fEmail;
        
        private IIS.Course_Registration.tGenderType fGender;
        
        private IIS.Course_Registration.Course fCourse;
        
        // *** Start programmer edit section *** (Student CustomMembers)

        // *** End programmer edit section *** (Student CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Student.Name CustomAttributes)

        // *** End programmer edit section *** (Student.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Student.Name Get start)

                // *** End programmer edit section *** (Student.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Student.Name Get end)

                // *** End programmer edit section *** (Student.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Student.Name Set start)

                // *** End programmer edit section *** (Student.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Student.Name Set end)

                // *** End programmer edit section *** (Student.Name Set end)
            }
        }
        
        /// <summary>
        /// Surname.
        /// </summary>
        // *** Start programmer edit section *** (Student.Surname CustomAttributes)

        // *** End programmer edit section *** (Student.Surname CustomAttributes)
        [StrLen(255)]
        public virtual string Surname
        {
            get
            {
                // *** Start programmer edit section *** (Student.Surname Get start)

                // *** End programmer edit section *** (Student.Surname Get start)
                string result = this.fSurname;
                // *** Start programmer edit section *** (Student.Surname Get end)

                // *** End programmer edit section *** (Student.Surname Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Student.Surname Set start)

                // *** End programmer edit section *** (Student.Surname Set start)
                this.fSurname = value;
                // *** Start programmer edit section *** (Student.Surname Set end)

                // *** End programmer edit section *** (Student.Surname Set end)
            }
        }
        
        /// <summary>
        /// BirthDate.
        /// </summary>
        // *** Start programmer edit section *** (Student.BirthDate CustomAttributes)

        // *** End programmer edit section *** (Student.BirthDate CustomAttributes)
        public virtual System.DateTime BirthDate
        {
            get
            {
                // *** Start programmer edit section *** (Student.BirthDate Get start)

                // *** End programmer edit section *** (Student.BirthDate Get start)
                System.DateTime result = this.fBirthDate;
                // *** Start programmer edit section *** (Student.BirthDate Get end)

                // *** End programmer edit section *** (Student.BirthDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Student.BirthDate Set start)

                // *** End programmer edit section *** (Student.BirthDate Set start)
                this.fBirthDate = value;
                // *** Start programmer edit section *** (Student.BirthDate Set end)

                // *** End programmer edit section *** (Student.BirthDate Set end)
            }
        }
        
        /// <summary>
        /// Email.
        /// </summary>
        // *** Start programmer edit section *** (Student.Email CustomAttributes)

        // *** End programmer edit section *** (Student.Email CustomAttributes)
        [StrLen(255)]
        public virtual string Email
        {
            get
            {
                // *** Start programmer edit section *** (Student.Email Get start)

                // *** End programmer edit section *** (Student.Email Get start)
                string result = this.fEmail;
                // *** Start programmer edit section *** (Student.Email Get end)

                // *** End programmer edit section *** (Student.Email Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Student.Email Set start)

                // *** End programmer edit section *** (Student.Email Set start)
                this.fEmail = value;
                // *** Start programmer edit section *** (Student.Email Set end)

                // *** End programmer edit section *** (Student.Email Set end)
            }
        }
        
        /// <summary>
        /// Gender.
        /// </summary>
        // *** Start programmer edit section *** (Student.Gender CustomAttributes)

        // *** End programmer edit section *** (Student.Gender CustomAttributes)
        public virtual IIS.Course_Registration.tGenderType Gender
        {
            get
            {
                // *** Start programmer edit section *** (Student.Gender Get start)

                // *** End programmer edit section *** (Student.Gender Get start)
                IIS.Course_Registration.tGenderType result = this.fGender;
                // *** Start programmer edit section *** (Student.Gender Get end)

                // *** End programmer edit section *** (Student.Gender Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Student.Gender Set start)

                // *** End programmer edit section *** (Student.Gender Set start)
                this.fGender = value;
                // *** Start programmer edit section *** (Student.Gender Set end)

                // *** End programmer edit section *** (Student.Gender Set end)
            }
        }
        
        /// <summary>
        /// Student.
        /// </summary>
        // *** Start programmer edit section *** (Student.Course CustomAttributes)

        // *** End programmer edit section *** (Student.Course CustomAttributes)
        [NotNull()]
        public virtual IIS.Course_Registration.Course Course
        {
            get
            {
                // *** Start programmer edit section *** (Student.Course Get start)

                // *** End programmer edit section *** (Student.Course Get start)
                IIS.Course_Registration.Course result = this.fCourse;
                // *** Start programmer edit section *** (Student.Course Get end)

                // *** End programmer edit section *** (Student.Course Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Student.Course Set start)

                // *** End programmer edit section *** (Student.Course Set start)
                this.fCourse = value;
                // *** Start programmer edit section *** (Student.Course Set end)

                // *** End programmer edit section *** (Student.Course Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "StudentE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View StudentE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("StudentE", typeof(IIS.Course_Registration.Student));
                }
            }
            
            /// <summary>
            /// "StudentL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View StudentL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("StudentL", typeof(IIS.Course_Registration.Student));
                }
            }
        }
    }
}