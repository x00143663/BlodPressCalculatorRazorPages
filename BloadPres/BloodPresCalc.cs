using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//x 00143663
namespace BloadPres
{

    public class BloodPresCalc
    {
        [Required(ErrorMessage = "Number must not be blank!")]
        [Display(Name = "Systolic")]
        [Range(70, 190, ErrorMessage = "Invalid Value")]
        public int Sys { get; set; }

        [Required(ErrorMessage = "Number must not be blank!")]
        [Display(Name = "Diastolic")]
        [Range(40, 100, ErrorMessage = "Invalid Value")]
        public int Dia { get; set; }


        public String PresureCateg
        {
            get
            {
                if (Dia > Sys)
                {
                    return "Wrong input Dia must be smaller than Sys";
                }
                else
                    if ((Sys > 140) || (Dia > 90))
                {
                    return "Hight blood presure";
                }
                else if ((Sys < 140) && (Sys >= 120) && ((Dia < 90) && (Dia >= 80))||(Sys>=120)&&(Sys<140) && ((Dia < 90)))
                {
                    return "Pre High Pressure";
                }
                else if ((Sys < 120) && (Sys >= 90) && ((Dia < 80) && (Dia >= 60))|| (Sys >= 90) && (Sys < 120) && ((Dia < 80)))
                {
                    return "Ideal Pressure";
                }
                else
                {
                    return "Low pressure";
                }
            }
        }
    }
}
