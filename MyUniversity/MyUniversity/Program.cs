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

                switch ( input_data )
                {
                    case "ReadCourses":
                        CommandHandler.ReadCourses();
                        break;
                    case "ReadStudents":
                        CommandHandler.ReadStudents();
                        break;
                    case "ReadInstructors":
                        CommandHandler.ReadInstructors();
                        break;
                    case "ReadGroups":
                        CommandHandler.ReadGroups();
                        break;
                    case "ReadOccupations":
                        CommandHandler.ReadOccupations();
                        break;
                    case "ReadChairs":
                        CommandHandler.ReadChairs();
                        break;
                    case "ReadGroupToOccupations":
                        CommandHandler.ReadGroupToOccupations();
                        break;
                    case "AddCourse":
                        CommandHandler.AddCourse();
                        break;
                    case "AddStudent":
                        CommandHandler.AddStudent();
                        break;
                    case "AddInstructor":
                        CommandHandler.AddInstructor();
                        break;
                    case "AddChair":
                        CommandHandler.AddChair();
                        break;
                    case "AddGroup":
                        CommandHandler.AddGroup();
                        break;
                    case "AddOccupation":
                        CommandHandler.AddOccupation();
                        break;
                    case "AddGroupToOccupation":
                        CommandHandler.AddGroupToOccupation();
                        break;
                    case "ChangeInstructorOnCourse":
                        CommandHandler.ChangeInstructorOnCourse();
                        break;
                    case "ReportOccupations":
                        CommandHandler.ReportOccupations();
                        break;
                    case "GeneralReport":
                        CommandHandler.GeneralReport();
                        break;
                    case "exit":
                        Console.WriteLine( "This close\n" );
                        flag = false;
                        break;
                    default:
                        Console.WriteLine( "Unknown command, please enter again\n" );
                        break;
                }
            }
        }

        public static void WriteCommands()
        {
            Console.WriteLine( "- ReadCourses" );
            Console.WriteLine( "- ReadStudents" );
            Console.WriteLine( "- ReadInstructors" );
            Console.WriteLine( "- ReadGroups" );
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
