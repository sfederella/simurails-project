namespace SimuRails.Views.Validables
{
    public interface Regla<V>
    {
        bool esValidaPara(V validado);

        string mensajePara(V validado);
    }
}