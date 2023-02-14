using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstructorAssignment
{
    internal class Instructor
    {
        public string Name { get; set; }
        public float avgfeedback { get; set; }
        public int experience { get; set; }
       public string[] instructorskill { get; set;}

        public Instructor(string name, float feedback, int exp, string[] instrucskill)
        {
            this.Name = name;
            this.avgfeedback = feedback;
            this.experience = exp;
            this.instruskill = instrucskill;

        }
        public CheckSkill(string technology)
        {  
           
            if(validateligibility() && instrucskill.Contains(technology))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public validateligibility()
        {
            
                if (experience > 3 && avgfeedback >= 4.5)
                {
                    return true;
                }
                else if (experience <= 3 && avgfeedback >= 4)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Experience: " + experience);
                    Console.WriteLine("Avg Feedback: " + avgfeedback);
                    return false;
                }
            }

        }

    }
