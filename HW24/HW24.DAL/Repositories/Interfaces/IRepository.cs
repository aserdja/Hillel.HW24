namespace HW24.DAL.Repositories.Interfaces
{
	public interface IRepository<T> where T : class
	{
		Task Add(T entity);
		Task Update(T entity);
		Task Delete(T entity);
	}
}
