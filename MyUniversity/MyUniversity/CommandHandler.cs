using System;
using System.Collections.Generic;

namespace MyUniversity
{
    public static class CommandHandler
    {
        public static void ReadCourses()
        {
            Console.WriteLine();
            Console.WriteLine( "Table Course: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", "CourseId", "NameCourse", "InstructorId" ) );
            List<Course> courses = QueryСlass.ReadCourses();
            foreach ( Course course in courses )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", course.CourseId, course.NameCourse, course.InstructorId ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void ReadStudents()
        {
            Console.WriteLine();
            Console.WriteLine( "Table Student: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}|{3, -30}", "StudentId", "NameStudent", "Age", "GroupId" ) );
            List<Student> students = QueryСlass.ReadStudents();
            foreach ( Student student in students )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}|{3, -30}", student.StudentId, student.NameStudent, student.Age, student.GroupId ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void ReadInstructors()
        {
            Console.WriteLine();
            Console.WriteLine( "Table Instructor: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", "InstructorId", "NameInstructor", "ChairId" ) );
            List<Instructor> instructors = QueryСlass.ReadInstructors();
            foreach ( Instructor instructor in instructors )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", instructor.InstructorId, instructor.NameInstructor, instructor.ChairId ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void ReadGroups()
        {
            Console.WriteLine();
            Console.WriteLine( "Table Group: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}", "GroupId", "NameGroup" ) );
            List<Group> groups = QueryСlass.ReadGroups();
            foreach ( Group group in groups )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}", group.GroupId, group.NameGroup ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void ReadOccupations()
        {
            Console.WriteLine();
            Console.WriteLine( "Table Occupation: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", "OccupationId", "NameOccupation", "CourseId" ) );
            List<Occupation> occupations = QueryСlass.ReadOccupations();
            foreach ( Occupation occupation in occupations )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", occupation.OccupationId, occupation.NameOccupation, occupation.CourseId ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void ReadChairs()
        {
            Console.WriteLine();
            Console.WriteLine( "Table Chair: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}", "ChairId", "NameChai" ) );
            List<Chair> chairs = QueryСlass.ReadChairs();
            foreach ( Chair chair in chairs )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}", chair.ChairId, chair.NameChair ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void ReadGroupToOccupations()
        {
            Console.WriteLine();
            Console.WriteLine( "Table Group_Occupation: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}", "GroupID", "OccupationId" ) );
            List<Group_Occupation> objectGOs = QueryСlass.ReadGroup_Occupations();
            foreach ( Group_Occupation objectGO in objectGOs )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}", objectGO.GroupId, objectGO.OccupationId ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void AddStudent()
        {
            Console.WriteLine();
            Console.WriteLine( "Enter student name: " );
            string name = Console.ReadLine();
            if ( name == "" )
            {
                Console.WriteLine( "Student name is empty, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            Console.WriteLine( "Enter student age: " );
            int age;
            if ( !Int32.TryParse( Console.ReadLine(), out age ) )
            {
                Console.WriteLine( "Student age is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            ReadGroups();
            Console.WriteLine( "Enter student group id: " );
            int groupId;
            if ( !Int32.TryParse( Console.ReadLine(), out groupId ) )
            {
                Console.WriteLine( "Group id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            List<Group> groups = QueryСlass.ReadGroups();
            int counter = 0;
            foreach ( Group group in groups )
            {
                if ( group.GroupId == groupId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This group id is not in the table, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            int createStudent = QueryСlass.InsertStudent( name, age, groupId );
            Console.WriteLine( "Created student: ", +createStudent + "\n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void AddInstructor()
        {
            Console.WriteLine();
            Console.WriteLine( "Enter instructor name: " );
            string name = Console.ReadLine();
            if ( name == "" )
            {
                Console.WriteLine( "Instructor name is empty, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            ReadChairs();
            Console.WriteLine( "Enter instructor chair id: " );
            int chairId;
            if ( !Int32.TryParse( Console.ReadLine(), out chairId ) )
            {
                Console.WriteLine( "Chair id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            List<Chair> chairs = QueryСlass.ReadChairs();
            int counter = 0;
            foreach ( Chair chair in chairs )
            {
                if ( chair.ChairId == chairId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This chair id is not in the table, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            int createInstructor = QueryСlass.InsertInstructor( name, chairId );
            Console.WriteLine( "Created instructor: ", +createInstructor + "\n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void AddChair()
        {
            Console.WriteLine();
            Console.WriteLine( "Enter chair name: " );
            string name = Console.ReadLine();
            if ( name == "" )
            {
                Console.WriteLine( "Chair name is empty, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            int createChair = QueryСlass.InsertChair( name );
            Console.WriteLine( "Created chair: ", +createChair + "\n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void AddCourse()
        {
            Console.WriteLine();
            Console.WriteLine( "Enter course name: " );
            string name = Console.ReadLine();
            if ( name == "" )
            {
                Console.WriteLine( "Course name is empty, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            ReadInstructors();
            Console.WriteLine( "Enter course instructor id: " );
            int instructorId;
            if ( !Int32.TryParse( Console.ReadLine(), out instructorId ) )
            {
                Console.WriteLine( "Instructor id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }


            List<Instructor> instructors = QueryСlass.ReadInstructors();
            int counter = 0;
            foreach ( Instructor instructor in instructors )
            {
                if ( instructor.InstructorId == instructorId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This instructor id is not in the table, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            int createCourse = QueryСlass.InsertCourse( name, instructorId );
            Console.WriteLine( "Created course: ", +createCourse + "\n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void AddGroup()
        {
            Console.WriteLine();
            Console.WriteLine( "Enter group name: " );
            string name = Console.ReadLine();
            if ( name == "" )
            {
                Console.WriteLine( "Group name is empty, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            int createGroup = QueryСlass.InsertGroup( name );
            Console.WriteLine( "Created group: ", +createGroup + "\n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void AddOccupation()
        {
            Console.WriteLine();
            Console.WriteLine( "Enter occupation name: " );
            string name = Console.ReadLine();
            if ( name == "" )
            {
                Console.WriteLine( "Occupation name is empty, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            ReadCourses();
            Console.WriteLine( "Enter occupation course id: " );
            int courseId;
            if ( !Int32.TryParse( Console.ReadLine(), out courseId ) )
            {
                Console.WriteLine( "Course id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            List<Course> courses = QueryСlass.ReadCourses();
            int counter = 0;
            foreach ( Course course in courses )
            {
                if ( course.CourseId == courseId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This course id is not in the table, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            int createOccupation = QueryСlass.InsertOccupation( name, courseId );
            Console.WriteLine( "Created occupation: ", +createOccupation + "\n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void AddGroupToOccupation()
        {
            Console.WriteLine();
            ReadGroups();
            Console.WriteLine( "Enter group id: " );
            int groupId;
            if ( !Int32.TryParse( Console.ReadLine(), out groupId ) )
            {
                Console.WriteLine( "Group id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            ReadOccupations();
            Console.WriteLine( "Enter occupation id: " );
            int occupationId;
            if ( !Int32.TryParse( Console.ReadLine(), out occupationId ) )
            {
                Console.WriteLine( "Occupation id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            List<Group> groups = QueryСlass.ReadGroups();
            int counter = 0;
            foreach ( Group group in groups )
            {
                if ( group.GroupId == groupId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This group id is not in the table group, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            counter = 0;
            List<Occupation> occupations = QueryСlass.ReadOccupations();
            foreach ( Occupation occupation in occupations )
            {
                if ( occupation.OccupationId == occupationId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This occupation id is not in the table occupation, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            QueryСlass.InsertGroup_Occupation( groupId, occupationId );
            Console.WriteLine( "Created group to occupation \n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void ChangeInstructorOnCourse()
        {
            Console.WriteLine();
            ReadCourses();
            Console.WriteLine( "Enter course id: " );
            int courseId;
            if ( !Int32.TryParse( Console.ReadLine(), out courseId ) )
            {
                Console.WriteLine( "Course id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            ReadInstructors();
            Console.WriteLine( "Enter instructor id: " );
            int instructorId;
            if ( !Int32.TryParse( Console.ReadLine(), out instructorId ) )
            {
                Console.WriteLine( "Instructor id is not digit, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            List<Course> courses = QueryСlass.ReadCourses();
            int counter = 0;
            foreach ( Course course in courses )
            {
                if ( course.CourseId == courseId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This course id is not in the table, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            List<Instructor> instructors = QueryСlass.ReadInstructors();
            counter = 0;
            foreach ( Instructor instructor in instructors )
            {
                if ( instructor.InstructorId == instructorId )
                {
                    counter++;
                }
            }
            if ( counter == 0 )
            {
                Console.WriteLine( "This instructor id is not in the table, please enter command again\n" );
                Console.WriteLine( "Error.\n" );
                return;
            }

            QueryСlass.UpdateCourse( courseId, instructorId );
            Console.WriteLine( "Changet instructor in group \n" );
            Console.WriteLine( "Success.\n" );
        }

        public static void ReportOccupations()
        {
            Console.WriteLine();
            Console.WriteLine( "Table report: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}", "OccupationId", "CountStudents" ) );
            List<Occupation_Student> reportstudents = QueryСlass.OccupationReports();
            foreach ( Occupation_Student reportstudent in reportstudents )
            {
                Console.WriteLine( String.Format( "{0, -30}|{1, -30}", reportstudent.OccupationId, reportstudent.StudentCount ) );
            }
            Console.WriteLine( "Success.\n" );
        }

        public static void GeneralReport()
        {
            Console.WriteLine();
            Console.WriteLine( "Table report: " );
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", "CountStudents", "CountInstructors", "CountOccupation" ) );
            ReportClass report = QueryСlass.GeneralReport();
            Console.WriteLine( String.Format( "{0, -30}|{1, -30}|{2, -30}", report.StudentCount, report.InstructorCount, report.OccupationCount ) );
            Console.WriteLine( "Success.\n" );
        }
    }
}
