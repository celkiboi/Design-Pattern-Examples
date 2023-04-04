using AbstractFactory.Products;

namespace AbstractFactory;

public interface IDessertFactory
{
    Cookie CreateCookie();
    Cake CreateCake();
    Donut CreateDonut();
}