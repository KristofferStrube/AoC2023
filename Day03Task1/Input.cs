﻿namespace Day03Task1;

public class Input
{
    public const string Literal =
"""
...............................930...................................283...................453.34.............................867....282....
....=.........370...........................48..456......424...-.341*.....554...*807.571............971..958............166......*..........
..159.........../..........539*.....73......-...*.......+....954.........*.....7.......*........*.....*....*.....405$..*.......31.........15
...............................873..*............726.............94.......126.........699....253....584..750................................
.660.................................336.....391.................*....860......76..................................435....576.....-.........
.................................888............*924...55......308.......*91.........446...535......87...136/........*...*........793.=351..
...........826...949...120...985..&....................*.......................462.../......*.........*.......358..932..599.479*............
............../.....%..*......%...............151.304..931..471.......601.....*............765........805....%..................149...345...
........................216..........................+......*............#..906...-......................................105...........&....
.......&..827*327.375-.................923.......*..........630......851..........459..656.......340.432........915.288....#.865*...........
.....693......................866......*......575.970...........201...................%........%...*.=...........+....*..........305.....666
.........%536......345..............166........................*....@905....863.&...........916..212.....386*963.....183....................
..............%......*.......&..664......=.........../726....960..............-.367...@..................................122................
...657.....939....915......326..&........367...498..................166...491........592...*650......*3...297.398..419......*...............
...*....................*3........................*....................*....*.....................673....*.....*......*......307.955........
....387......537......12......319-...........474...216....600..........14.59...21.....................132.......466...787........*....967...
.........593..*...=......422.............=.....................63........................593=...............556..................94.....$...
..........*....8.690......#....871....955...920............646..*......383..573..121.$............931*738...........................608.....
...........256..................*............*....903*......*...478....*....@...&....733............................796...+.....109.........
.....=354..............=..579.529.............346.....754..715.........174.....................$........368*595.....*......576....$....-....
905/.............417.20.....*...............#..................103.............795.....829...611...................653.........%.......882..
...........@....*...........65.246...714.724.........529=......@...490...614&.#.........#.........678.343......................446..........
.......111.400..371...............*....*...........................*.......................*........*.........341.......262........334......
...979...*.............310.....912..314.....864......*162.........612...252*805...956...359.712....69.....921...*..........*..922%....*.....
....=...576...............*462................*...978.......381......................*................549....%...502......455.........927...
............................................163................*293......953.908..242............786.....*30..........628.....930...........
....622......498.746..13*......87*.383...................347.........162..*.........................#...................&....*...../521.....
....$.........&.....*....841............/....730....584.....*.792=......*.207.963........356....................828........60............80.
...................548............456#..815....$...@.....357.........619......*.............@.................-.......................15....
....858..................+....................................560..............617.....818.............*.....248.977....323..906..350..*....
.......=.........754......881...860...........160............*...........#................*.........144.696......*...................#..852.
.........#758.......=.............*...........*...873.......341...........765.............534....................537....-...543.152.........
................847.....130*650..450......#.188.....*...........137.453..........229...=..............199..718........462..........*........
.839....#949............................742.......322..............*................*...260..........#.....*...............486......560.....
...............426.63.&...620..137.441/......212.............%......................898.........#.......185...#796.619.971../...............
................*...@.445.*......*.................745&...662.............................&723.189....................*...........653*......
...533....854..83.........447..377.....#..%....593.............@.................@........................#.............$.............729...
......*......&....284................887.183....#....446*220.749...........732....538...................327.......356...793.....703.........
....187..........%....117.....730................................192&......*.................%754...................*..............*479..757
.............323..........236.........=372.....%.......60.=.............193.......-......66..................632....798...&.............*...
.........177*.........413....*....=............670....*....571....................823....$..-85.........998...............899...........805.
...&.............772.......81....513.....478.......106..........+218..........584.................*553...%..881$...994......................
...51..974...558*....................+..*................655*..........841......+.........387..565....................=.....................
.....................290.....555..156...220..................343...515.............34.888..=.................442.........#..........982*448.
.....405......341.....@........$...................56.474...........*.....224-.559*...*.............$..185..............852.................
......../........*191..........................443...*....+.276.....................106..........415..*.................................823.
....242.....................545..56........548..*.......78..*...288*169.519../737....................889....806..................*404.......
...*..........#....873*....$....&.....#.52...*.706.........891.....................282.......+..+727........................&...........754.
920............731.....56..........772...*.654.................84.788.........147..*.......872............690....*.....454...648.710....*...
.........585...........................273................561....*......*203...................982*......*.......772.....=.......*...255....
.................665.......566.....#........182..669*..............+..24......544..........18.........291......................283..........
...........871.....=..946...*....69..................292.929.318.564.......=....*.....-...%................761-.812.691....17...............
..........*......&........603...............@..684..........*..............38.120.....715..........268.../.........*......=...344.448*704...
.865../....404..994.354........=.#738....535....+..=..........134.........................=..862.......215.939.......821*....#..............
.....207...............=.....103..................77..192....*......$......./...........898.../.............*....672.....526.........623....
.........................638..................306........$..174......537.146...204..........................961.+................%...-......
.......297*479....643....*.....293.......711...*....812............+...........*........513.............................#522...185.....811..
128......................517..*.....87.......183.......*.........676....531..81...........*....191../..............................435.*....
.....752..........+...........535....................242....474............+.....@.......902......*..779...184.....242*.....484.../....222..
.......*..........870.....994......265....403................@.................395...235.......827............*472.....212....=.............
.....84...............&......$....*..........*......137.#................/.........&..$..775.............730................................
......................497.18.....444.......43......./...943..110..........672.....881.......*402............&.....369.38......*.............
.168/.=121........414........%........572.............$...........................................808...........=....*...#759.379...........
...............-.....*570....468...............@......770......./.................537....=.480*...%....%.......820..........................
160..........72......................&...607.920...............399........746.........510.............736.............448.....123.......995.
.....868........947.....206..........438................474........+...........148...........=.............-......%..............#.....@....
................*......*......................+.....416...*.........337.....................6....413/.......695..287..20....................
...%..........137....867............957....704..458....*...867.722..................-...765..........................*...........529%...706.
...416.241.........-.....950..........*..........*...20.....................307....388.....*..581.572................9..592.................
.......*.......877..79.....#.........795...#..+..35.............*552...884..../..........165.....*....287....@...........*.............843..
......777.186....*..............743......85..239....*137.....282..........*..........914..............*.....798.........815.....908...=.....
..924............48..............*.....................................597...56..................84..700.........321........................
......%...397.................38..........703...133...........412............*..235..........................913*....+.....320.650*829......
.6...11....*..646.........168..#..................*......-737...........764.6.....*.339*....835.......................372....-..............
.........724...*.....440.....*....996*241.213.....158...................%......800......342....*..333......219.604...................370*661
....................@.....23.60............................%.......598.......................920....#.........*.....522.........446.........
......55....$965.........%..............909...=.......587..55.............*132.....................................*....185*617.+.......851.
..725.*...........................470.....$.592......*.........448...................564*412..........872.....639.................*.....*...
......975..+.....%......166........................372....691+...*...+..........369............+.......+..235....@....%........128.770......
...........857.614.......*.........$...........491..............49...893...........*251.....249....................887.....475..............
........................112......809...........*...........366...................*................880+.......................@...@...*.363..
.................774............................874..851....*...........344$..426.863........72&.........*990.......@..........511.420..*...
..274........215...*..=............912...............&...#.647..864.....................904......281..491..........329....185...........887.
....&............727..328..457............358..........965.....*......678&..............*..........*........................*....823........
...................................=.......*...313=...........97...........282.711.539.692.....616..413.&352..........58...741..$.......840.
..372.561......548..........337$.108....191...................................*...................*...........*583.....*....................
....*.........*....93..459..........................114*..................44.....885.............482...753.901........297....&.....@.814....
...895....613.186......*.......762.913..................547.832.744..230....*31..*.....................*....................947.487..*......
.........%........&.387...489.....*....970....712...376.....#....*...@..........884...446.............457.130*160.......730...........400...
.....687...%...119...........*......91*..........+.....*.......553...................*.......160....................791*......$...466.......
.......*.898.........988....341......................140...........360.........47..424.......#....@566...%545..............606.....*........
....375......538......*..........................344............-.*...........*........246.............................10..........193......
716.....848..........387........89...............*.......276.866..689......99.552.......%........678....186.$....199..#.....................
...@.%......279................../..........*.865.....%....*................................178...*.....*....119...*........740.............
......138...*...........853.460.....340...917.........731...653.....836*536..........*434......*..970....98........847.......=..119.........
..339.......478...........#....*.....*...........4................................968.......656............................-......=....178..
.../.............641........432...854......626...#......643*.......740........549................583.......................108......+...&...
.............292*.......762............784*.........................*.........*......469*........*.......475...................371..485.....
........536=..............*.................................&....493.........987.831.....270.375..371.....*............519......+...........
...26..........892......264....348...23........639....587.251.....................-............*..........282....765..*.......=.........985.
.../...276.....-....................*...........&.....*........-.$609................259....980..978............*...........13....@897......
........$................961%........845...843.....741.......792...........288...734*....+........*.............800.566.....................
..............+704.............46.......................243...................$.......503......351..........466................861*51.......
..732.........................&.....&..747.............*..............452.........612..........................*........64...$........97....
....*............................825.....-...........922......................218*........254.554.....$..691...116...........678......*.....
..128.501....42.836............................225.$.....@613.486....................657....*...*....325..*...........................105...
........*........*....333...2....................*.595...............698..57=...........*..6....174.......738.......*.......................
....208...925.752........-....................939...................$..........715+..262.............952........916.643....326......607.....
......*....*.........79.........118......................@...615...........629...............449.....*......843..*........%..........$......
....216...754....182*...345.255...=.367................990...*.....=285.....................*.....421..........*.377........................
........................*...*..........*283...182...........339...............328.%...544....979.............454........978....478..........
..........491$.......995.....141.....@........*....................=.....932.*....985...*..............................*......*.............
...201.............@..............814......723...............955.895....*....563......................958...............667...274..147......
......=..+463...273....%..............152.............443.....*.........836................900........=...........................%.........
..558.................124...89........#...158...../........473..208.........................*..772............................732.....25....
......891......................674*......=.....835.................*535...64........891..611...*....-...72....519.........%....%............
.........*.......%618..............48......783.............337.............*........*.............835..*.....*............965...............
.......380................................*......................511*310...724.......858...%681.........635.289........................679..
.....=...................*836...........754..231.....565*...........................................446........................978......*...
..907......=..........886.....836..472...................773..827.......16.....$.......................*...............&49...*.........949..
..........93..............#......#....*........$..............*..........+..215...161....128............791..................308............
......$......741....379@...895.........153......14...........430..................&..../....*.983............885....91...............=......
.....572....*...............................494.........................890...687....334..385..*........43/........*...............481.%....
.........472.....%.$.....699..278...975....*............109.....................................47..........................323........837..
................64.697....*...........*...282......58......*............345.959.29.........*432.......204......834.........$....4...........
..........974-...........89....254.................@...-..280...41..132.*...*.....$.....132..............$..........19/........*............
................228..............*....662.....119.....100.........*.-...950..119....................990......64.291.........309..270*461....
...............$...............885...+...........*..@...........27....................860....../......&.430.......*.........................
.......445*............................132......787..885.............+...634....................654.......*.......219.......................
...121.....564...................745..*....172............848-.....404...@..............$.812.......&....................259...........12...
...*................130...792........353.....*.795..........................383..690..53.....*.......385.&677..598*.......=....500.34./.....
245....*827...........*....*..............555.......505.....766...941........*.....*........599....................804.............&........
....438.....67.138....580.297..241............-992.+........#....#..........728...645....41......660....................................87..
..............*...............*.....609.63..........................*......................*324....#......353.......-............+..........
.............................581...-..........230.........486....239.808.......*......12..................$......816.....367.....512........
.838......357...779...707.............79.630.#.............+..26............248.858...../...152.....279.....*...............*...............
....*339...$............*...@....-26......*....296......25...%.....178..=.................+....-...*......493............................554
.....................666...147.........195...............................279.......119.....739....887...........@.521.........98............
................................405*.......................29...%1...................*........................754...#.........*.............
961.........396.....................472.......225..739..............415............451......................................904.............
""";
}
