using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samiTimeTable
{
    static class SqlMethods
    {
        public const string TIMETABLE = "TimeTable";

        public static string getTable(string table)
        {
            string str = "SELECT * FROM " + table;
            return str;
        }
        public static string getTableAsSet(string table, string key)
        {
            return
                "SELECT DISTINCT (" + key +") "
                +" FROM " + table + " ORDER BY " +key + " ASC";
        }
        public static string searchKey(string table, string key, string value)
        {
            return
                "SELECT * FROM " + table + " WHERE " + key + " = " + "'" + value + "'";
        }
        public static string searchLecture(string table, string key, string value)
        {
            return
                "SELECT * FROM " + table 
                + " WHERE " + key + " = " + "'" + value + "'"
                + " AND Type = 'Lecture'";
        }
        public static string searchPs(string table, string key, string value)
        {
            return
                "SELECT * FROM " + table
                + " WHERE " + key + " = " + "'" + value + "'"
                + " AND Type = 'Practical Session'";
        }
        public static string addClass(string name, string type, string teacher, string room, string day, string start, string end)
        {
            return
            "DECLARE @nameParam nvarchar(100), @typeParam nvarchar(100), @teachParam nvarchar(100), "
            + "@roomParam nvarchar(100), @dayParam nvarchar(100), "
            + "@startParam time, @endParam time"
            + " set @nameParam = N'" + name + "'" + " set @typeParam = N'" + type + "'"
            + " set @roomParam = N'" + room + "'" + " set @dayParam = N'" + day + "'"
            + " set @startParam = N'" + start + "'" + " set @endParam = N'" + end + "'"
            + " set @teachParam = N'" + teacher + "'"
            + " IF NOT EXISTS (SELECT * FROM " + TIMETABLE + " WHERE "
            + " Name = @nameParam AND Type = @typeParam AND Room = @roomParam AND Teacher = @teachParam "
            + "AND Day = @dayParam AND StartingTime = @startParam AND EndingTime = @endParam )"
            + "INSERT INTO " + TIMETABLE + " (Name, Type, Teacher, Room, Day, StartingTime, EndingTime) "
            + "VALUES "
            + "(@nameParam, @typeParam, @teachParam, @roomParam, @dayParam, @startParam, @endParam)";
        }
        public static string deleteByID(string ID)
        {
            return
                "delete from TimeTable "
                +" where ID in (" + ID +" )"; 
        }
        public static string deleteTable(string table)
        {
            return
                "IF OBJECT_ID('" + table + "') IS NOT NULL"
                + " BEGIN DROP TABLE " + table + " END";
        }
    }
}
