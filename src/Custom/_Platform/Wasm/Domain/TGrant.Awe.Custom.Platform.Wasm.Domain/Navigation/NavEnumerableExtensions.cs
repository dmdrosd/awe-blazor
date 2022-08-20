namespace TGrant.Awe.Custom.Platform.Wasm.Domain.Navigation
{
    public static class NavEnumerableExtensions
    {
        public static void ForEachNav<T>(this
            #nullable disable
            IEnumerable<T> items, Action<T> action)
        {
            if (items == null)
            {
                return;
            }

            foreach (var obj in items)
            {
                action(obj);
            }
        }
    }
}
