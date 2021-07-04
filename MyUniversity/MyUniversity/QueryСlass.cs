using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyUniversity
{
    public static class QueryСlass
    {
        private static string _connectionString = @"Data Source=DUKE\SQLEXPRESS; Initial Catalog=my_university; Pooling=true; Integrated Security=SSPI";

        public static List<Course> ReadCourses()
        {
            List<Course> courses = new List<Course>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [CorseId],
                            [NameCourse],
                            [InstructorId]
                        FROM [Course]";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var course = new Course
                            {
                                CourseId = Convert.ToInt32(reader[ "CorseId" ] ),
                                NameCourse = Convert.ToString(reader[ "NameCourse" ] ),
                                InstructorId = Convert.ToInt32(reader[ "InstructorId" ] ),
                            };
                            courses.Add( course );
                        }
                    }
                }
                return courses;
            }
        }

        public static List<Student> ReadStudents()
        {
            List<Student> students = new List<Student>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [StudentId],
                            [NameStudent],
                            [Age],
                            [GroupId]
                        FROM [Student]";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var student = new Student
                            {
                                StudentId = Convert.ToInt32( reader[ "StudentId" ] ),
                                NameStudent = Convert.ToString( reader[ "NameStudent" ] ),
                                GroupId = Convert.ToInt32( reader[ "GroupId" ] ),
                                Age = Convert.ToInt32( reader[ "Age" ] )
                            };
                            students.Add( student );
                        }
                    }
                }
                return students;
            }
        }

        public static List<Instructor> ReadInstructors()
        {
            List<Instructor> instructors = new List<Instructor>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [InstructorId],
                            [NameInstructor],
                            [ChairId]
                        FROM [Instructor]";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var instructor = new Instructor
                            {
                                InstructorId = Convert.ToInt32( reader[ "InstructorId" ] ),
                                NameInstructor = Convert.ToString( reader[ "NameInstructor" ] ),
                                ChairId = Convert.ToInt32( reader[ "ChairId" ] ),
                            };
                            instructors.Add( instructor );
                        }
                    }
                }
                return instructors;
            }
        }

        public static List<Group> ReadGroups()
        {
            List<Group> groups = new List<Group>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [GroupId],
                            [NameGroup]
                        FROM [Group]";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var group = new Group
                            {
                                GroupId = Convert.ToInt32( reader[ "GroupId" ] ),
                                NameGroup = Convert.ToString( reader[ "NameGroup" ] )
                            };
                            groups.Add( group );
                        }
                    }
                }
                return groups;
            }
        }

        public static List<Occupation> ReadOccupations()
        {
            List<Occupation> occupations = new List<Occupation>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [OccupationId],
                            [NameOccupation],
                            [CorseId]
                        FROM [Occupation]";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var occupation = new Occupation
                            {
                                OccupationId = Convert.ToInt32( reader[ "OccupationId" ] ),
                                NameOccupation = Convert.ToString( reader[ "NameOccupation" ] ),
                                CourseId = Convert.ToInt32( reader[ "CorseId" ] ),
                            };
                            occupations.Add( occupation );
                        }
                    }
                }
                return occupations;
            }
        }

        public static List<Chair> ReadChairs()
        {
            List<Chair> chairs = new List<Chair>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [ChairId],
                            [NameChair]
                        FROM [Chair]";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var chair = new Chair
                            {
                                ChairId = Convert.ToInt32( reader[ "ChairId" ] ),
                                NameChair = Convert.ToString( reader[ "NameChair" ] )
                            };
                            chairs.Add( chair );
                        }
                    }
                }
                return chairs;
            }
        }

        public static List<Group_Occupation> ReadGroup_Occupations()
        {
            List<Group_Occupation> objectGOs = new List<Group_Occupation>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [GroupId],
                            [OccupationId]
                        FROM [Group_Occupation]";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var objectGO = new Group_Occupation
                            {
                                GroupId = Convert.ToInt32( reader[ "GroupId" ] ),
                                OccupationId = Convert.ToInt32( reader[ "OccupationId" ] )
                            };
                            objectGOs.Add( objectGO );
                        }
                    }
                }
                return objectGOs;
            }
        }

        public static int InsertStudent( string studentName, int age, int groupId )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand cmd = connection.CreateCommand() )
                {
                    cmd.CommandText = @"
                    INSERT INTO [Student]
                        ([NameStudent],
                         [Age],
                         [GroupId])
                    VALUES 
                       (@studentName,
                        @age,
                        @groupId)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add( "@studentName", SqlDbType.NVarChar ).Value = studentName;
                    cmd.Parameters.Add( "@age", SqlDbType.NVarChar ).Value = age;
                    cmd.Parameters.Add( "@groupId", SqlDbType.Int ).Value = groupId;

                    return Convert.ToInt32( cmd.ExecuteScalar() );
                }
            }
        }

        public static int InsertInstructor( string instructorName, int chairId )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand cmd = connection.CreateCommand() )
                {
                    cmd.CommandText = @"
                    INSERT INTO [Instructor]
                        ([NameInstructor],
                         [ChairId])
                    VALUES 
                       (@instructorName,
                        @chairId)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add( "@instructorName", SqlDbType.NVarChar ).Value = instructorName;
                    cmd.Parameters.Add( "@chairId", SqlDbType.Int ).Value = chairId;

                    return Convert.ToInt32( cmd.ExecuteScalar() );
                }
            }
        }

        public static int InsertChair( string chairName )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand cmd = connection.CreateCommand() )
                {
                    cmd.CommandText = @"
                    INSERT INTO [Chair]
                        ([NameChair])
                    VALUES 
                       (@chairName)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add( "@chairName", SqlDbType.NVarChar ).Value = chairName;

                    return Convert.ToInt32( cmd.ExecuteScalar() );
                }
            }
        }

        public static int InsertCourse( string courseName, int instructorId )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand cmd = connection.CreateCommand() )
                {
                    cmd.CommandText = @"
                    INSERT INTO [Course]
                        ([NameCourse],
                         [InstructorId])
                    VALUES 
                       (@courseName,
                        @instructorId)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add( "@courseName", SqlDbType.NVarChar ).Value = courseName;
                    cmd.Parameters.Add( "@instructorId", SqlDbType.Int ).Value = instructorId;

                    return Convert.ToInt32( cmd.ExecuteScalar() );
                }
            }
        }

        public static int InsertGroup( string groupName )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand cmd = connection.CreateCommand() )
                {
                    cmd.CommandText = @"
                    INSERT INTO [Group]
                        ([NameGroup])
                    VALUES 
                       (@groupName)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add( "@groupName", SqlDbType.NVarChar ).Value = groupName;

                    return Convert.ToInt32( cmd.ExecuteScalar() );
                }
            }
        }

        public static int InsertOccupation( string occupationName, int courseId )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand cmd = connection.CreateCommand() )
                {
                    cmd.CommandText = @"
                    INSERT INTO [Occupation]
                        ([NameOccupation],
                         [CorseId])
                    VALUES 
                       (@occupationName,
                        @courseId)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add( "@occupationName", SqlDbType.NVarChar ).Value = occupationName;
                    cmd.Parameters.Add( "@courseId", SqlDbType.Int ).Value = courseId;

                    return Convert.ToInt32( cmd.ExecuteScalar() );
                }
            }
        }

        public static void InsertGroup_Occupation( int groupId, int occupationId )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand cmd = connection.CreateCommand() )
                {
                    cmd.CommandText = @"
                    INSERT INTO [Group_Occupation]
                        ([GroupId],
                         [OccupationId])
                    VALUES 
                       (@groupId,
                        @occupationId)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add( "@groupId", SqlDbType.Int ).Value = groupId;
                    cmd.Parameters.Add( "@occupationId", SqlDbType.Int ).Value = occupationId;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateCourse( int courseId, int instructorId )
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText = @"
                        UPDATE [Course]
                        SET 
                        [InstructorId] = @instructorId
                        WHERE [CorseId] = @courseId";

                    command.Parameters.Add( "@courseId", SqlDbType.Int ).Value = courseId;
                    command.Parameters.Add( "@instructorId", SqlDbType.NVarChar ).Value = instructorId;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Occupation_Student> OccupationReports()
        {
            List<Occupation_Student> reportstudents = new List<Occupation_Student>();
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT oc.OccupationId, COUNT(s.GroupId) AS count
                            FROM [Student] s
                            JOIN [Group] g ON g.GroupId = s.GroupId
                            JOIN [Group_Occupation] gro ON gro.GroupId = g.GroupId
                            JOIN [Occupation] oc ON oc.OccupationId = gro.OccupationId
                            GROUP BY oc.OccupationId
                            ORDER BY oc.OccupationId";

                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            var reportstudent = new Occupation_Student
                            {
                                OccupationId = Convert.ToInt32( reader[ "OccupationId" ] ),
                                StudentCount = Convert.ToInt32( reader[ "count" ] )
                            };
                            reportstudents.Add( reportstudent );
                        }
                    }
                }
                return reportstudents;
            }
        }

        public static ReportClass GeneralReport()
        {
            using ( SqlConnection connection = new SqlConnection( _connectionString ) )
            {
                ReportClass report = new ReportClass();
                connection.Open();
                using ( SqlCommand command = new SqlCommand() )
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"
                        SELECT count(s.StudentId) AS sum_student,
                        (SELECT count(i.InstructorId) FROM [Instructor] i) AS sum_instructor, 
                        (SELECT count(o.OccupationId) FROM [Occupation] o) AS sum_occupation
                        FROM [Student] s
                        ";
                    using ( SqlDataReader reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            report = new ReportClass
                            {
                                StudentCount = Convert.ToInt32( reader[ "sum_student" ] ),
                                InstructorCount = Convert.ToInt32( reader[ "sum_instructor" ] ),
                                OccupationCount = Convert.ToInt32( reader[ "sum_occupation" ] )
                            };
                        }
                    }
                }
                return report;
            }
        }
    }
}
