namespace AssignmentT
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用StudentRequestDto给Student赋值

            StudentRequestDto dto = new StudentRequestDto()
            {
                Name = "张三",
                Address = "xx路1号",
                Sex = 1,// 1 男，0 女
            };

            Student student = AssignmentT.ToT<Student>(dto, new Student());

            //测试student是否是New的对象
            dto.Name = "李四";
            dto.Sex = 2;
        }
    }
}
