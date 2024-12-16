### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Template method pattern
This pattern is usefull when the algorithm is fixed, with template method you can customize the specific step, but not the whole structure. 1
The step remain the same, but change their implementation. \
Reduce code dupliation, clients is only allowed to modify certain steps can be hard to maintain if the number of steps grow up. 

**STRATEGY** > is useful when you want define a family of interchargeable algorithms, each algorith is incapsulated inside own class. With Strategy you can dinamically select different algorithms at runtime depending by the context, decoupling client code from specific implementation