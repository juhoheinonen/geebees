module Server

open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open Saturn

open Shared

type Storage() =
    let todos = ResizeArray<_>()

    let getrandomitem (list:Todo List) =  
        let rand = new System.Random()
        let result = list.[rand.Next(list.Length)]
        Some result

    member __.GetTodos() = List.ofSeq todos |> getrandomitem

    member __.AddTodo(todo: Todo) =
        if Todo.isValid todo.Description then
            todos.Add todo
            Ok()
        else
            Error "Invalid todo"

let storage = Storage()

storage.AddTodo(Todo.create ("What lies behind us and what lies before us are tiny matters compared to what lies within us.", "Ralph Waldo Emerson"))
|> ignore
storage.AddTodo(Todo.create ("Tough times never last, but tough people do.", "Robert H. Schuller"))
|> ignore
storage.AddTodo(Todo.create ("It is impossible to live without failing at something, unless you live so cautiously that you might as well not have lived at all, in which case you have failed by default.", "J.K. Rowling"))
|> ignore
storage.AddTodo(Todo.create ("Life is not easy for any of us. But what of that? We must have perseverance and, above all, confidence in ourselves. We must believe that we are gifted for something, and that this thing, at whatever cost, must be attained.", "Marie Curie"))
|> ignore
storage.AddTodo(Todo.create ("A life spent making mistakes is not only more honorable but more useful than a life spent in doing nothing.", "George Bernard Shaw"))
|> ignore
storage.AddTodo(Todo.create ("Make up your mind that no matter what comes your way, no matter how difficult, no matter how unfair, you will do more than simply survive. You will thrive in spite of it.", "Joel Osteen"))
|> ignore
storage.AddTodo(Todo.create ("A man may fail many times but he isn’t a failure until he begins to blame somebody else.", "John Burroughs"))
|> ignore
storage.AddTodo(Todo.create ("In the depth of winter, I finally learned that within me there lay an invincible summer.", "Albert Camus"))
|> ignore
storage.AddTodo(Todo.create ("Although no one can go back and make a brand new start, anyone can start from now and make a brand new ending.", "Carl Bard"))
|> ignore
storage.AddTodo(Todo.create ("Anyone can hide. Facing up to things, working through them, that’s what makes you strong.", "Sarah Dessen"))
|> ignore
storage.AddTodo(Todo.create ("If one dream should fall and break into a thousand pieces, never be afraid to pick one of those pieces up and begin again.", "Flavia Weedn"))
|> ignore
storage.AddTodo(Todo.create ("When one door of happiness closes, another opens, but often we look so long at the closed door that we do not see the one that has been opened for us.", "Helen Keller"))
|> ignore
storage.AddTodo(Todo.create ("When you’re feeling your worst, that’s when you get to know yourself the best.", "Leslie Grossman"))
|> ignore
storage.AddTodo(Todo.create ("The deeper that sorrow carves into your being, the more joy you can contain.Is not the cup that holds your wine the very cup that was burned in the potter’s oven?And is not the lute that soothes your spirit, the very wood that was hollowed with knives?When you are joyous, look deep into your heart and you shall find it is only that which has given you sorrow that is giving you joy. When you are sorrowful look again in your heart, and you shall see in truth that you are weeping for that which has been your delight.", "Kahlil Gibran"))
|> ignore
storage.AddTodo(Todo.create ("In the middle of every difficulty lies opportunity.", "Albert Einstein"))
|> ignore
storage.AddTodo(Todo.create ("Fall seven times, stand up eight.", "Chinese Proverb"))
|> ignore
storage.AddTodo(Todo.create ("Do what you feel in your heart to be right, for you'll be criticized anyway. You'll be damned if you do and damned if you don't.", "Eleanor Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("I’ve missed more than 9000 shots in my career. I’ve lost almost 300 games. 26 times, I’ve been trusted to take the game winning shot and missed. I’ve failed over and over and over again in my life. And that is why I succeed.", "Michael Jordan"))
|> ignore
storage.AddTodo(Todo.create ("Success is not final, failure is not fatal: it is the courage to continue that counts.", "Winston Churchill"))
|> ignore
storage.AddTodo(Todo.create ("Failure is simply the opportunity to begin again, this time more intelligently.", "Henry Ford"))
|> ignore
storage.AddTodo(Todo.create ("It is not the critic who counts; not the man who points out how the strong man stumbles, or where the doer of deeds could have done them better.The credit belongs to the man who is actually in the arena, whose face is marred by dust and sweat and blood, who strives valiantly; who errs and comes short again and again; because there is not effort without error and shortcomings; but who does actually strive to do the deed; who knows the great enthusiasm, the great devotion, who spends himself in a worthy cause, who at the best knows in the end the triumph of high achievement and who at the worst, if he fails, at least he fails while daring greatly.So that his place shall never be with those cold and timid souls who know neither victory nor defeat.", "Theodore Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("Life's real failure is when you do not realize how close you were to success when you gave up.", "Unknown"))
|> ignore
storage.AddTodo(Todo.create ("With the new day comes new strength and new thoughts.", "Eleanor Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("I love the man that can smile in trouble, that can gather strength from distress, and grow brave by reflection. ’Tis the business of little minds to shrink, but he whose heart is firm, and whose conscience approves his conduct, will pursue his principles unto death.", "Thomas Paine"))
|> ignore
storage.AddTodo(Todo.create ("Ever tried. Ever failed. No matter. Try Again. Fail again. Fail better.", "Samuel Beckett"))
|> ignore
storage.AddTodo(Todo.create ("Strength does not come from winning. Your struggles develop your strengths. When you go through hardships and decide not to surrender, that is strength.", "Arnold Schwarzenegger"))
|> ignore
storage.AddTodo(Todo.create ("A hero is an ordinary individual who finds the strength to persevere and endure in spite of overwhelming obstacles.", "Christopher Reeve"))
|> ignore
storage.AddTodo(Todo.create ("You gain strength, courage, and by every experience in which you really stop to look fear in the face. You are able to say to yourself, ‘I lived through this horror. I can take the next thing that comes along.'", "Eleanor Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("Some of us think holding on makes us strong, but sometimes it is letting go.", "Hermann Hesse"))
|> ignore
storage.AddTodo(Todo.create ("Remember that failure is an event, not a person.", "Zig Ziglar"))
|> ignore

storage.AddTodo(Todo.create ("At any given moment you have the power to say: This is not how the story is going to end.", "Christine Mason Miller"))
|> ignore
storage.AddTodo(Todo.create ("Courage doesn’t always roar. Sometimes courage is the quiet voice at the end of the day saying, 'I will try again tomorrow.'", "Mary Anne Radmacher"))
|> ignore
storage.AddTodo(Todo.create ("Do the hard jobs first. The easy jobs will take care of themselves.", "Dale Carnegie"))
|> ignore
storage.AddTodo(Todo.create ("Think of many things; do one.", "Portuguese proverb"))
|> ignore
storage.AddTodo(Todo.create ("Do not be embarrassed by your failures, learn from them and start again.", "Richard Branson"))
|> ignore

storage.AddTodo(Todo.create ("Amateurs sit and wait for inspiration, the rest of us just get up and go to work.", "Stephen King"))
|> ignore
storage.AddTodo(Todo.create ("Time is an equal opportunity employer. Each human being has exactly the same number of hours and minutes every day. Rich people can't buy more hours. Scientists can't invent new minutes. And you can't save time to spend it on another day. Even so, time is amazingly fair and forgiving. No matter how much time you've wasted in the past, you still have an entire tomorrow.", "Denis Waitley"))
|> ignore
storage.AddTodo(Todo.create ("You've got to get up every morning with determination if you're going to go to bed with satisfaction.", "George Lorimer"))
|> ignore
storage.AddTodo(Todo.create ("If you want to make an easy job seem mighty hard, just keep putting off doing it.", "Olin Miller"))
|> ignore
storage.AddTodo(Todo.create ("In a moment of decision, the best thing you can do is the right thing to do, the next best thing is the wrong thing, and the worst thing you can do is nothing.", "Theodore Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("Follow effective actions with quiet reflection. From the quiet reflection will come even more effective action.", "Peter Drucker"))
|> ignore
storage.AddTodo(Todo.create ("I attribute my success to this: I never gave or took any excuse.", "Florence Nightingale"))
|> ignore
storage.AddTodo(Todo.create ("I can accept failure, everyone fails at something. But I can’t accept not trying.", "Michael Jordan"))
|> ignore
storage.AddTodo(Todo.create ("Nothing is less productive than to make more efficient what should not be done at all.", "Peter Drucker"))
|> ignore
storage.AddTodo(Todo.create ("If you don’t pay appropriate attention to what has your attention, it will take more of your attention than it deserves.", "David Allen"))
|> ignore
storage.AddTodo(Todo.create ("Success does not consist in never making mistakes but in never making the same one a second time.", "George Bernard Shaw"))
|> ignore
storage.AddTodo(Todo.create ("Try not to become a person of success, but rather try to become a person of value.", "Albert Einstein"))
|> ignore
storage.AddTodo(Todo.create ("The secret of success in life is for a man to be ready for his opportunity when it comes.", "Benjamin Disraeli"))
|> ignore
storage.AddTodo(Todo.create ("You don’t have to see the whole staircase, just take the first step.", "Martin Luther King, Jr."))
|> ignore
storage.AddTodo(Todo.create ("Take time to deliberate; but when the time for action arrives, stop thinking and go in.", "Napoleon Bonaparte"))
|> ignore
storage.AddTodo(Todo.create ("Things may come to those who wait, but only the things left by those who hustle.", "Abraham Lincoln"))
|> ignore
storage.AddTodo(Todo.create ("I find that the harder I work, the more luck I seem to have.", "Thomas Jefferson"))
|> ignore
storage.AddTodo(Todo.create ("Much of the stress that people feel doesn't come from having too much to do. It comes from not finishing what they started.", "David Allen"))
|> ignore
storage.AddTodo(Todo.create ("Doing the best at this moment puts you in the best place for the next moment.", "Oprah Winfrey"))
|> ignore
storage.AddTodo(Todo.create ("You have to learn the rules of the game. And then you have to play better than anyone else.", "Albert Einstein"))
|> ignore
storage.AddTodo(Todo.create ("If I had eight hours to chop down a tree, I’d spend six hours sharpening my ax.", "Abraham Lincoln"))
|> ignore
storage.AddTodo(Todo.create ("Most of the important things in the world have been accomplished by people who have kept on trying when there seemed to be no hope at all.", "Dale Carnegie"))
|> ignore
storage.AddTodo(Todo.create ("Keep away from people who try to belittle your ambitions. Small people always do that, but the really great make you feel that you, too, can become great.", "Mark Twain"))
|> ignore
storage.AddTodo(Todo.create ("The successful warrior is the average man, with laser-like focus.", "Bruce Lee"))
|> ignore
storage.AddTodo(Todo.create ("Success is not the key to happiness. Happiness is the key to success. If you love what you are doing, you will be successful.", "Herman Cain"))
|> ignore
storage.AddTodo(Todo.create ("Keep on going, and the chances are that you will stumble on something, perhaps when you are least expecting it. I never heard of anyone ever stumbling on something sitting down.", "Charles F. Kettering"))
|> ignore
storage.AddTodo(Todo.create ("Nothing in the world can take the place of perseverance. Talent will not; nothing is more common than unsuccessful people with talent. Genius will not; unrewarded genius is almost legendary. Education will not; the world is full of educated derelicts. Perseverance and determination alone are omnipotent.", "Calvin Coolidge"))
|> ignore
storage.AddTodo(Todo.create ("You yourself, as much as anybody in the entire universe, deserve your love and affection.", "Buddha"))
|> ignore
storage.AddTodo(Todo.create ("When you get into a tight place and everything goes against you, till it seems as though you could not hang on a minute longer, never give up then, for that is just the place and time that the tide will turn.", "Harriet Beecher Stowe"))
|> ignore
storage.AddTodo(Todo.create ("You have power over your mind – not outside events. Realize this, and you will find strength.", "Marcus Aurelius"))
|> ignore
storage.AddTodo(Todo.create ("That man is richest whose pleasures are cheapest.", "Henry David Thoreau"))
|> ignore
storage.AddTodo(Todo.create ("You're always with yourself, so you might as well enjoy the company.", "Diane Von Furstenberg"))
|> ignore
storage.AddTodo(Todo.create ("Some people believe holding on and hanging in there are signs of great strength. However, there are times when it takes much more strength to know when to let go and then do it.", "Ann Landers"))
|> ignore
storage.AddTodo(Todo.create ("Adversity is like a strong wind. It tears away from us all but the things that cannot be torn, so that we see ourselves as we really are.", "Arthur Golden"))
|> ignore
storage.AddTodo(Todo.create ("Every adversity, every failure, every heartache carries with it the seed of a greater or equal benefit.", "Napoleon Hill"))
|> ignore
storage.AddTodo(Todo.create ("Love recognizes no barriers. It jumps hurdles, leaps fences, penetrates walls to arrive at its destination full of hope.", "Maya Angelou"))
|> ignore
storage.AddTodo(Todo.create ("It takes courage to love, but pain through love is the purifying fire which those who love generously know. We all know people who are so much afraid of pain that they shut themselves up like clams in a shell and, giving out nothing, receive nothing and therefore shrink until life is a mere living death.", "Eleanor Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("The unhappy derive comfort from the misfortunes of others.", "Aesop"))
|> ignore
storage.AddTodo(Todo.create ("Never idealize others. They will never live up to your expectations. Don’t over-analyze your relationships. Stop playing games. A growing relationship can only be nurtured by genuineness. ", "Leo F. Buscaglia"))
|> ignore
storage.AddTodo(Todo.create ("Life is very interesting. In the end, some of your greatest pains become your greatest strengths.", "Drew Barrymore"))
|> ignore
storage.AddTodo(Todo.create ("Love yourself first and everything else falls into line. You really have to love yourself to get anything done in this world.", "Lucille Ball"))
|> ignore
storage.AddTodo(Todo.create ("A healthy self-love means we have no compulsion to justify to ourselves or others why we take vacations, why we sleep late, why we buy new shoes, why we spoil ourselves from time to time. We feel comfortable doing things which add quality and beauty to life.", "Andrew Matthews"))
|> ignore
storage.AddTodo(Todo.create ("I found in my research that the biggest reason people aren't more self-compassionate is that they are afraid they'll become self-indulgent. They believe self-criticism is what keeps them in line. Most people have gotten it wrong because our culture says being hard on yourself is the way to be.", "Kristen Neff"))
|> ignore
storage.AddTodo(Todo.create ("Don’t wait. The time will never be just right.", "Napoleon Hill"))
|> ignore
storage.AddTodo(Todo.create ("Happiness is a state of activity.", "Aristotle"))
|> ignore
storage.AddTodo(Todo.create ("The way to love anything is to realize that it may be lost.", "Gilbert K. Chesterton"))
|> ignore
storage.AddTodo(Todo.create ("All the adversity I’ve had in my life, all my troubles and obstacles, have strengthened me… You may not realize it when it happens, but a kick in the teeth may be the best thing in the world for you.", "Walt Disney"))
|> ignore
storage.AddTodo(Todo.create ("Whenever you’re in conflict with someone, there is one factor that can make the difference between damaging your relationship and deepening it. That factor is attitude.", "William James"))
|> ignore
storage.AddTodo(Todo.create ("You can make more friends in two months by becoming interested in other people than you can in two years by trying to get other people interested in you.", "Dale Carnegie"))
|> ignore
storage.AddTodo(Todo.create ("If you would be loved, love, and be loveable.", "Benjamin Franklin"))
|> ignore
storage.AddTodo(Todo.create ("Since you get more joy out of giving joy to others, you should put a good deal of thought into the happiness that you are able to give.", "Eleanor Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("What you do not want done to yourself, do not do to others.", "Confucius"))
|> ignore
storage.AddTodo(Todo.create ("When you hold resentment toward another, you are bound to that person or condition by an emotional link that is stronger than steel. Forgiveness is the only way to dissolve that link and get free.", "Catherine Ponder"))
|> ignore
storage.AddTodo(Todo.create ("If you aren’t good at loving yourself, you will have a difficult time loving anyone, since you’ll resent the time and energy you give another person that you aren’t even giving to yourself.", "Barbara De Angelis"))
|> ignore
storage.AddTodo(Todo.create ("Your task is not to seek for love, but merely to seek and find all the barriers within yourself that you have built against it.", "Rumi"))
|> ignore
storage.AddTodo(Todo.create ("When the Japanese mend broken objects, they aggrandize the damage by filling the cracks with gold. They believe that when something's suffered damage and has a history it becomes more beautiful.", "Barbara Bloom"))
|> ignore
storage.AddTodo(Todo.create ("Love is not only something you feel, it is something you do.", "David Wilkerson"))
|> ignore
storage.AddTodo(Todo.create ("Every person has to love at least one bad partner in their lives to be truly thankful for the right one.", "Unknown"))
|> ignore
storage.AddTodo(Todo.create ("You know it's love when all you want is that person to be happy, even if you're not part of their happiness.", "Julia Roberts"))
|> ignore
storage.AddTodo(Todo.create ("'Tis better to have loved and lost than never to have loved at all.", "Alfred Lord Tennyson"))
|> ignore
storage.AddTodo(Todo.create ("Just because it didn’t last forever, doesn’t mean it wasn’t worth your while.", "Unknown"))
|> ignore
storage.AddTodo(Todo.create ("The pleasure which we most rarely experience gives us greatest delight.", "Epictetus"))
|> ignore
storage.AddTodo(Todo.create ("The most beautiful people we have known are those who have known defeat, known suffering, known struggle, known loss, and have found their way out of the depths. These persons have an appreciation, a sensitivity and an understanding of life that fills them with compassions, gentleness, and a deep loving concern. Beautiful people do not just happen.", "Elizabeth Kubler-Ross"))
|> ignore
storage.AddTodo(Todo.create ("Don’t brood. Get on with living and loving. You don’t have forever.", "Leo Buscaglia"))
|> ignore
storage.AddTodo(Todo.create ("When you arise in the morning, think of what a precious privilege it is to be alive – to breathe, to think, to enjoy, to love.", "Marcus Aurelius"))
|> ignore
storage.AddTodo(Todo.create ("Happiness is not something ready-made. It comes from your own actions.", "Dalai Lama"))
|> ignore
storage.AddTodo(Todo.create ("Thousands of candles can be lighted from a single candle, and the life of the candle will not be shortened. Happiness never decreases by being shared.", "Buddha"))
|> ignore
storage.AddTodo(Todo.create ("Maxim for life: You get treated in life the way you teach people to treat you.", "Wayne Dyer"))
|> ignore
storage.AddTodo(Todo.create ("If you want happiness for an hour — take a nap.'If you want happiness for a day — go fishing.If you want happiness for a year — inherit a fortune.If you want happiness for a lifetime — help someone else.", "Chinese Proverb"))
|> ignore
storage.AddTodo(Todo.create ("To dare is to lose one’s footing momentarily. To not dare is to lose oneself.", "Soren Kierkegaard"))
|> ignore
storage.AddTodo(Todo.create ("It isn't what you have, or who you are, or where you are, or what you are doing that makes you happy or unhappy. It is what you think about.", "Dale Carnegie"))
|> ignore
storage.AddTodo(Todo.create ("When a resolute young fellow steps up to the great bully, the world, and takes him boldly by the beard, he is often surprised to find it comes off in his hand, and that it was only tied on to scare away the timid adventurers.", "Ralph Waldo Emerson"))
|> ignore
storage.AddTodo(Todo.create ("If you always put limit on everything you do, physical or anything else. It will spread into your work and into your life. There are no limits. There are only plateaus, and you must not stay there, you must go beyond them.", "Bruce Lee"))
|> ignore
storage.AddTodo(Todo.create ("There is only one way to happiness and that is to cease worrying about things which are beyond the power of our will.", "Epictetus"))
|> ignore
storage.AddTodo(Todo.create ("The foolish man seeks happiness in the distance, the wise grows it under his feet.", "James Oppenheim"))
|> ignore
storage.AddTodo(Todo.create ("You’ll always miss 100% of the shots you don’t take.", "Wayne Gretzky"))
|> ignore
storage.AddTodo(Todo.create ("Success is the sum of small efforts, repeated day-in and day-out.", "Robert Collier"))
|> ignore
storage.AddTodo(Todo.create ("The best years of your life are the ones in which you decide your problems are your own. You do not blame them on your mother, the ecology, or the president. You realize that you control your own destiny.", "Albert Ellis"))
|> ignore
storage.AddTodo(Todo.create ("Be miserable. Or motivate yourself. Whatever has to be done, it's always your choice.", "Wayne Dyer"))
|> ignore
storage.AddTodo(Todo.create ("It's been my experience that you can nearly always enjoy things if you make up your mind firmly that you will.", "L.M. Montgomery"))
|> ignore
storage.AddTodo(Todo.create ("Plenty of people miss their share of happiness, not because they never found it, but because they didn’t stop to enjoy it.", "William Feather"))
|> ignore
storage.AddTodo(Todo.create ("I, not events, have the power to make me happy or unhappy today. I can choose which it shall be. Yesterday is dead, tomorrow hasn't arrived yet. I have just one day, today, and I'm going to be happy in it.", "Groucho Marx"))
|> ignore
storage.AddTodo(Todo.create ("There are more things to alarm us than to harm us, and we suffer more often in apprehension than reality.", "Seneca"))
|> ignore

storage.AddTodo(Todo.create ("If you are too busy to laugh, you are too busy.", "Proverb"))
|> ignore
storage.AddTodo(Todo.create ("We tend to forget that happiness doesn't come as a result of getting something we don't have, but rather of recognizing and appreciating what we do have.", "Frederick Keonig"))
|> ignore
storage.AddTodo(Todo.create ("Aim for success, not perfection. Never give up your right to be wrong, because then you will lose the ability to learn new things and move forward with your life. Remember that fear always lurks behind perfectionism.", "David M. Burns"))
|> ignore
storage.AddTodo(Todo.create ("To be kind to all, to like many and love a few, to be needed and wanted by those we love, is certainly the nearest we can come to happiness.", "Mary Stuart"))
|> ignore
storage.AddTodo(Todo.create ("No act of kindness, no matter how small, is ever wasted.", "Aesop"))
|> ignore
storage.AddTodo(Todo.create ("Try a thing you haven’t done three times. Once, to get over the fear of doing it. Twice, to learn how to do it. And a third time to figure out whether you like it or not.", "Virgil Thomson"))
|> ignore
storage.AddTodo(Todo.create ("Never say never, because limits, like fears, are often just an illusion.", "Michael Jordan"))
|> ignore
storage.AddTodo(Todo.create ("Time you enjoy wasting is not wasted time.", "Marthe Troly-Curtin"))
|> ignore
storage.AddTodo(Todo.create ("The first recipe for happiness is: avoid too lengthy meditation on the past.", "Andre Maurois"))
|> ignore
storage.AddTodo(Todo.create ("You can't really be strong until you can see a funny side to things.", "Ken Kesey"))
|> ignore
storage.AddTodo(Todo.create ("Success isn’t permanent and failure isn’t fatal.", "Mike Ditka"))
|> ignore
storage.AddTodo(Todo.create ("Your attitude, not your aptitude, will determine your altitude.", "Zig Ziglar"))
|> ignore
storage.AddTodo(Todo.create ("Loving people live in a loving world. Hostile people live in a hostile world. Same world.", "Wayne Dyer"))
|> ignore
storage.AddTodo(Todo.create ("Worry never robs tomorrow of its sorrow. It only saps today of its joy.", "Leo Buscaglia"))
|> ignore
storage.AddTodo(Todo.create ("Spend eighty percent of your time focusing on the opportunities of tomorrow rather than the problems of yesterday.", "Brian Tracy"))
|> ignore
storage.AddTodo(Todo.create ("Happiness is not in the mere possession of money; it lies in the joy of achievement, in the thrill of creative effort.", "Franklin D. Roosevelt"))
|> ignore
storage.AddTodo(Todo.create ("The only real failure in life is not to be true to the best one knows.", "Buddha"))
|> ignore
storage.AddTodo(Todo.create ("I’ve come to believe that all my past failure and frustrations were actually laying the foundation for the understandings that have created the new level of living I now enjoy.", "Anthony Robbins"))
|> ignore
storage.AddTodo(Todo.create ("Every great dream begins with a dreamer. Always remember, you have within you the strength, the patience, and the passion to reach for the stars to change the world.", "Harriet Tubman"))
|> ignore
storage.AddTodo(Todo.create ("Everything you want is on the other side of fear.", "Jack Canfield"))
|> ignore
storage.AddTodo(Todo.create ("There came a time when the risk to remain tight in the bud was more painful than the risk it took to blossom.", "Anaïs Nin"))
|> ignore
storage.AddTodo(Todo.create ("The happiest people in the world are those who feel absolutely terrific about themselves, and this is the natural outgrowth of accepting total responsibility for every part of their life.", "Brian Tracy"))
|> ignore
storage.AddTodo(Todo.create ("The best way to succeed in this world is to act on the advice you give to others.", "Unknown"))
|> ignore
storage.AddTodo(Todo.create ("When things go wrong as they sometimes will,When the road you’re trudging seems all uphill,When the funds are low and the debts are high,And you want to smile but you have to sigh,When care is pressing you down a bitRest if you must, but don’t you quit.Success is failure turned inside out,The silver tint on the clouds of doubt,And you can never tell how close you are,It may be near when it seems afar.So, stick to the fight when you’re hardest hitIt’s when things go wrong that you mustn’t quit.", "Edgar A. Guest"))
|> ignore
storage.AddTodo(Todo.create ("A year from now you may wish you had started today.", "Karen Lamb"))
|> ignore
storage.AddTodo(Todo.create ("Follow your bliss and don’t be afraid, and doors will open where you didn’t know they were going to be.", "Joseph Campbell"))
|> ignore
storage.AddTodo(Todo.create ("Twenty years from now you will be more disappointed by the things that you didn't do than by the ones you did do. So throw off the bowlines. Sail away from the safe harbor. Catch the trade winds in your sails. Explore. Dream. Discover.", "Mark Twain"))
|> ignore
storage.AddTodo(Todo.create ("To laugh often and much; to win the respect of intelligent people and the affection of children… to leave the world a better place… to know even one life has breathed easier because you have lived. This is to have succeeded.", "Ralph Waldo Emerson"))
|> ignore
storage.AddTodo(Todo.create ("In life it’s usually wise to trust that everything’s going well, even when that’s not what you really believe. All too often threats have started to actually materialise namely because people have been preparing to deal with them.", "Mauno Koivisto"))
|> ignore

let todosApi =
    { getTodos = fun () -> async { return storage.GetTodos() }
      addTodo =
          fun todo ->
              async {
                  match storage.AddTodo todo with
                  | Ok () -> return todo
                  | Error e -> return failwith e
              } }

let webApp =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.fromValue todosApi
    |> Remoting.buildHttpHandler

let app =
    application {
        url "http://0.0.0.0:8085"
        use_router webApp
        memory_cache
        use_static "public"
        use_gzip
    }

run app
