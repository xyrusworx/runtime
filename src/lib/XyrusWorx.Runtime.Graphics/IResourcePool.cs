using JetBrains.Annotations;

namespace XyrusWorx.Runtime.Graphics 
{
	[PublicAPI]
	public interface IResourcePool<in T> where T: class, IMemoryBlock
	{
		[CanBeNull]
		T this[int slot] { set; }
	}
}