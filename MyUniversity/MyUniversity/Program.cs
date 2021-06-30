using System;

namespace MyUniversity
{
    class Program
    {
        static void Main( string[] args )
        {
            bool flag = true;
            while ( flag )
            {
                Console.WriteLine( "Available commands: " );
                WriteCommands();
                Console.WriteLine( "Please enter the command: " );
                string input_data = Console.ReadLine();

                if ( input_data.Equals( "ReadCourses" ) )
                {
                    CommandHandler.ReadCourses();
                }

                else if ( input_data.Equals( "ReadStudents" ) )
                {
                    CommandHandler.ReadStudents();
                }

                else if ( input_data.Equals( "ReadInstructors" ) )
                {
                    CommandHandler.ReadInstructors();
                }

                else if ( input_data.Equals( "ReadGroups" ) )
                {
                    CommandHandler.ReadGroups();
                }

                else if ( input_data.Equals( "ReadOccupations" ) )
                {
                    CommandHandler.ReadOccupations();
                }

                else if ( input_data.Equals( "ReadChairs" ) )
                {
                    CommandHandler.ReadChairs();
                }

                else if ( input_data.Equals( "ReadGroupToOccupations" ) )
                {
                    CommandHandler.ReadGroupToOccupations();
                }

                else if ( input_data.Equals( "AddCourse" ) )
                {
                    CommandHandler.AddCourse();
                }

                else if ( input_data.Equals( "AddStudent" ) )
                {
                    CommandHandler.AddStudent();
                }

                else if ( input_data.Equals( "AddInstructor" ) )
                {
                    CommandHandler.AddInstructor();
                }

                else if ( input_data.Equals( "AddChair" ) )
                {
                    CommandHandler.AddChair();
                }

                else if ( input_data.Equals( "AddGroup" ) )
                {
                    CommandHandler.AddGroup();
                }

                else if ( input_data.Equals( "AddOccupation" ) )
                {
                    CommandHandler.AddOccupation();
                }

                else if ( input_data.Equals( "AddGroupToOccupation" ) )
                {
                    CommandHandler.AddGroupToOccupation();
                }

                else if ( input_data.Equals( "ChangeInstructorOnCourse" ) )
                {
                    CommandHandler.ChangeInstructorOnCourse();
                }

                else if ( input_data.Equals( "ReportOccupations" ) )
                {
                    CommandHandler.ReportOccupations();
                }

                else if ( input_data.Equals( "GeneralReport" ) )
                {
                    CommandHandler.GeneralReport();
                }

                else if ( input_data.Equals( "exit" ) )
                {
                    Console.WriteLine( "This close\n" );
                    flag = false;
                }

                else
                {
                    Console.WriteLine( "Unknown command, please enter again\n" );
                }
            }
        }

        public static void WriteCommands()
        {
            Console.WriteLine( "- ReadCourses" );
            Console.WriteLine( "- ReadStudents" );
            Console.WriteLine( "- ReadInstructors" );
            Console.WriteLine( "- ReadOccupations" );
            Console.WriteLine( "- ReadChairs" );
            Console.WriteLine( "- ReadGroupToOccupations" );
            Console.WriteLine( "- AddCourse" );
            Console.WriteLine( "- AddStudent" );
            Console.WriteLine( "- AddInstructor" );
            Console.WriteLine( "- AddChair" );
            Console.WriteLine( "- AddGroup" );
            Console.WriteLine( "- AddOccupation" );
            Console.WriteLine( "- AddGroupToOccupation" );
            Console.WriteLine( "- ChangeInstructorOnCourse" );
            Console.WriteLine( "- ReportOccupations" );
            Console.WriteLine( "- GeneralReport" );
            Console.WriteLine( "- exit" );
        }
    }
}
