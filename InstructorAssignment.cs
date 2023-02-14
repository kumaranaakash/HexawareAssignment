using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment1
{
    internal class Instructor
    {
        public string Name { get; set; }
        public float avgfeedback { get; set; }
        public int experience { get; set; }
       public string[] instructorskill { get; set;}

        public Instructor(string name, float feedback, int exp, string[] instructorskill)
        {
            this.Name = name;
            this.avgfeedback = feedback;
            this.experience = exp;
            this.instructorskill = instructorskill;

        }
        public bool CheckSkill(string technology)
        {  
           
            if(validateligibility() && instructorskill.Contains(technology))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool validateligibility()
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
