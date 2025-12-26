namespace SOLID;
//ISP violation
public interface IWorker
{
    void Work();
    void ManageEmployees();
    void AttendMeetings();
    void FileReports();
}
//public class Employee : IWorker
//{
//    public void AttendMeetings()
//    {
//        throw new NotImplementedException();
//    }

//    public void FileReports()
//    {
//        throw new NotImplementedException();
//    }

//    public void ManageEmployees()
//    {
//        throw new NotImplementedException();
//    }

//    public void Work()
//    {
//        throw new NotImplementedException();
//    }
//}

//ISP-Adhering refactoring 
public interface IWorkable
{
    void Work();
}

public interface IManageable
{
    void ManageEmployees();
}

public interface IMeetingAttendable
{
    void AttendMeetings();
}

public interface IReportable
{
    void FileReports();
}
public class Employee : IWorkable, IMeetingAttendable, IReportable
{
    public void AttendMeetings()
    {
        throw new NotImplementedException();
    }

    public void FileReports()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}