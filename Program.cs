using Behavioral_TemplateMethod;

/*
 * TEMPLATE METHOD PATTERN
 * is usefull when the algorithm is fixed,, with template method you can customize the specific step, but not the whole structure
 * the step remain the same, but change their implementation
 * reduce code dupliation, clients is only allowed to modify certain steps
 * can be hard to maintain if the number of steps grow up
 * STRATEGY > is useful when you want define a family of interchargeable algorithms, each algorith is incapsulated inside own class
 * with Strategy you can dinamically select different algorithms at runtime depending by the context, decoupling client code from specific implementation
 */

//using polimorphism and strategy patter
//MusicPlayer_STRATEGY player = new MusicPlayer_STRATEGY(new MusicCasset_STRATEGY());
//player.PlaySound();

//player.SetPlayer(new CdPlayer_STRATEGY());
//player.PlaySound();


//use inheritance and template method
CdPlayer cdPlayer = new CdPlayer();
cdPlayer.PlaySound();

MusicCasset mPlayer = new MusicCasset();
mPlayer.PlaySound();

Technics1200 turnatble = new Technics1200();
turnatble.PlaySound();