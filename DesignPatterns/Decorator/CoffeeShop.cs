using System.Collections.Generic;
using System.Linq;

public interface IIngredient {
    decimal Price();
}

public class Coffee : IIngredient {
    private IIngredient _ingredient;

    public Coffee(IIngredient ingredient){
        _ingredient = ingredient;
    }

    public decimal Price (){
        return (_ingredient?.Price()).GetValueOrDefault() + 1.0m;
    }
}

public class Sugar : IIngredient {
    private IIngredient _ingredient;

    public Sugar(IIngredient ingredient){
        _ingredient = ingredient;
    }
    public decimal Price(){
        return (_ingredient?.Price()).GetValueOrDefault() + 0.10m;
    }
}

public class Cookie : IIngredient {
    private readonly IIngredient _ingredient;

    public Cookie(IIngredient ingredient){
        _ingredient = ingredient;
    }

    public decimal Price () {
        return (_ingredient?.Price()).GetValueOrDefault() + 5.0m;
    }
}

public class Order {

    private IList<IIngredient> _list = new List<IIngredient>();

    public void AddIngredient(IIngredient ingredient){
        _list.Add(ingredient);
    }

    public decimal Cost () {
        return _list.Sum(x => x.Price());
    }
    
    
}

public class DecoratorRun {

    public void Run (){

        // var order = new Order();
        // order.AddIngredient(new Coffee());
        // order.AddIngredient(new Sugar());

        // var cost = order.Cost();

        IIngredient ingr = new Coffee(null);
        ingr = new Sugar(ingr);
        ingr = new Cookie(ingr);

        var cost = ingr.Price();


    }

}