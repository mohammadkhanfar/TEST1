namespace Student.Interservice
{
    public interface Iservicess<student>
    {
        List<student> GetAll();
        student Getbyid(int id);
        List<student> Insert(student item);
        List<student> Delete(int id);

    }
}
