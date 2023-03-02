namespace DILifetime.Services
{
    public class SomeService : ITransientService, IScopedService, ISingletonService
    {
        Guid _id;

        public SomeService()
        {
            _id = Guid.NewGuid(); //nếu là id mới thì hàm SomeService sẽ tạo guid mới
        }
        public Guid GetID()
        {
            return _id;
        }
    }
}
