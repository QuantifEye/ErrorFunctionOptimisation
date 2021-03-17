using System;
using static System.Math;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Meta.Numerics.Extended;

namespace Example
{
    public static class OptimisedImplementation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplA(double z)
        {
            const double n0 = 0.0033791670955125737;
            const double n1 = -0.0007369565304816795;
            const double n2 = -0.3747323373929196;
            const double n3 = 0.08174424487335873;
            const double n4 = -0.04210893199365486;
            const double n5 = 0.007016570951209575;
            const double n6 = -0.004950912559824351;
            const double n7 = 0.0008716465990379225;

            const double d0 = 1.0;
            const double d1 = -0.21808821808792464;
            const double d2 = 0.4125429727254421;
            const double d3 = -0.08418911478731067;
            const double d4 = 0.06553388564002416;
            const double d5 = -0.012001960445494177;
            const double d6 = 0.00408165558926174;
            const double d7 = -0.0006159007215577697;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(n7,
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(d7,
                                            z, d6),
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplB(double z)
        {
            const double n0 = -0.03617903907182625;
            const double n1 = 0.2922518834448827;
            const double n2 = 0.2814470417976045;
            const double n3 = 0.12561020886276694;
            const double n4 = 0.027413502826893053;
            const double n5 = 0.0025083967216806575;

            const double d0 = 1.0;
            const double d1 = 1.8545005897903486;
            const double d2 = 1.4357580303783142;
            const double d3 = 0.5828276587530365;
            const double d4 = 0.12481047693294975;
            const double d5 = 0.011372417654635328;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(n5,
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(d5,
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplC(double z)
        {
            const double n0 = -0.03978768926111369;
            const double n1 = 0.1531652124678783;
            const double n2 = 0.19126029560093624;
            const double n3 = 0.10276327061989304;
            const double n4 = 0.029637090615738836;
            const double n5 = 0.004609348678027549;
            const double n6 = 0.0003076078203486802;

            const double d0 = 1.0;
            const double d1 = 1.955200729876277;
            const double d2 = 1.6476231719938486;
            const double d3 = 0.7682386070221262;
            const double d4 = 0.20979318593650978;
            const double d5 = 0.031956931689991336;
            const double d6 = 0.0021336316089578537;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(n6,
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(d6,
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplD(double z)
        {
            const double n0 = -0.030083856055794972;
            const double n1 = 0.05385788298444545;
            const double n2 = 0.07262115416519142;
            const double n3 = 0.036762846988804936;
            const double n4 = 0.009646290155725275;
            const double n5 = 0.0013345348007529107;
            const double n6 = 7.780875997825043E-05;

            const double d0 = 1.0;
            const double d1 = 1.7596709814716753;
            const double d2 = 1.3288357143796112;
            const double d3 = 0.5525285965087576;
            const double d4 = 0.13379305694133287;
            const double d5 = 0.017950964517628076;
            const double d6 = 0.0010471244001993736;
            const double d7 = -1.0664038182035734E-08;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(n6,
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(d7,
                                            z, d6),
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplE(double z)
        {
            const double n0 = -0.011790757013722784;
            const double n1 = 0.01426213209053881;
            const double n2 = 0.020223443590296084;
            const double n3 = 0.009306682999904321;
            const double n4 = 0.00213357802422066;
            const double n5 = 0.00025022987386460105;
            const double n6 = 1.2053491221958819E-05;

            const double d0 = 1.0;
            const double d1 = 1.5037622520362048;
            const double d2 = 0.9653977862044629;
            const double d3 = 0.3392652304767967;
            const double d4 = 0.06897406495415698;
            const double d5 = 0.007710602624917683;
            const double d6 = 0.0003714211015310693;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(n6,
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(d6,
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplF(double z)
        {
            const double n0 = -0.005469547955387293;
            const double n1 = 0.004041902787317071;
            const double n2 = 0.005496336955316117;
            const double n3 = 0.002126164726039454;
            const double n4 = 0.0003949840144950839;
            const double n5 = 3.655654770644424E-05;
            const double n6 = 1.3548589710993232E-06;

            const double d0 = 1.0;
            const double d1 = 1.2101969777363077;
            const double d2 = 0.6209146682211439;
            const double d3 = 0.17303843066114277;
            const double d4 = 0.027655081377343203;
            const double d5 = 0.0024062597442430973;
            const double d6 = 8.918118172513365E-05;
            const double d7 = -4.655288362833827E-12;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(n6,
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(d7,
                                            z, d6),
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplG(double z)
        {
            const double n0 = -0.0027072253590577837;
            const double n1 = 0.00131875634250294;
            const double n2 = 0.0011992593326100233;
            const double n3 = 0.00027849619811344664;
            const double n4 = 2.6782298821833186E-05;
            const double n5 = 9.230436723150282E-07;

            const double d0 = 1.0;
            const double d1 = 0.8146328085431416;
            const double d2 = 0.26890166585629954;
            const double d3 = 0.044987721610304114;
            const double d4 = 0.0038175966332024847;
            const double d5 = 0.00013157189788859692;
            const double d6 = 4.048153596757641E-12;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(n5,
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(d6,
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplH(double z)
        {
            const double n0 = -0.001099467206917422;
            const double n1 = 0.00040642544275042267;
            const double n2 = 0.0002744994894169007;
            const double n3 = 4.652937706466594E-05;
            const double n4 = 3.2095542539576746E-06;
            const double n5 = 7.782860181450209E-08;

            const double d0 = 1.0;
            const double d1 = 0.5881737106118461;
            const double d2 = 0.13936333128940975;
            const double d3 = 0.016632934041708368;
            const double d4 = 0.0010002392131023491;
            const double d5 = 2.4254837521587224E-05;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(n5,
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(d5,
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplI(double z)
        {
            const double n0 = -0.0005690799360109496;
            const double n1 = 0.00016949854037376225;
            const double n2 = 5.184723545811009E-05;
            const double n3 = 3.8281931223192885E-06;
            const double n4 = 8.249899312818944E-08;

            const double d0 = 1.0;
            const double d1 = 0.33963725005113937;
            const double d2 = 0.04347264787031066;
            const double d3 = 0.002485493352246371;
            const double d4 = 5.356333053371529E-05;
            const double d5 = -1.1749094440545958E-13;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(n4,
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(d5,
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplJ(double z)
        {
            const double n0 = -0.00024131359948399134;
            const double n1 = 5.742249752025015E-05;
            const double n2 = 1.1599896292738377E-05;
            const double n3 = 5.817621344025938E-07;
            const double n4 = 8.539715550856736E-09;

            const double d0 = 1.0;
            const double d1 = 0.23304413829968784;
            const double d2 = 0.02041869405464403;
            const double d3 = 0.0007971856475643983;
            const double d4 = 1.1701928167017232E-05;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(n4,
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(d4,
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplK(double z)
        {
            const double n0 = -0.00014667469927776036;
            const double n1 = 1.6266655211228053E-05;
            const double n2 = 2.6911624850916523E-06;
            const double n3 = 9.79584479468092E-08;
            const double n4 = 1.0199464762572346E-09;

            const double d0 = 1.0;
            const double d1 = 0.16590781294484722;
            const double d2 = 0.010336171619150588;
            const double d3 = 0.0002865930263738684;
            const double d4 = 2.9840157084090034E-06;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(n4,
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(d4,
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplL(double z)
        {
            const double n0 = -5.839057976297718E-05;
            const double n1 = 4.125103251054962E-06;
            const double n2 = 4.3179092242025094E-07;
            const double n3 = 9.933651555900132E-09;
            const double n4 = 6.534805100201047E-11;

            const double d0 = 1.0;
            const double d1 = 0.10507708607203992;
            const double d2 = 0.004142784286754756;
            const double d3 = 7.263387546445238E-05;
            const double d4 = 4.778184710473988E-07;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(n4,
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(d4,
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplM(double z)
        {
            const double n0 = -1.9645779760922958E-05;
            const double n1 = 1.572438876668007E-06;
            const double n2 = 5.439025111927009E-08;
            const double n3 = 3.174724923691177E-10;

            const double d0 = 1.0;
            const double d1 = 0.05280398924095763;
            const double d2 = 0.0009268760691517533;
            const double d3 = 5.410117232266303E-06;
            const double d4 = 5.350938458036424E-16;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(n3,
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(d4,
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfImplN(double z)
        {
            const double n0 = -7.892247039787227E-06;
            const double n1 = 6.22088451660987E-07;
            const double n2 = 1.457284456768824E-08;
            const double n3 = 6.037155055427153E-11;

            const double d0 = 1.0;
            const double d1 = 0.03753288463562937;
            const double d2 = 0.0004679195359746253;
            const double d3 = 1.9384703927584565E-06;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(n3,
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(d3,
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfInvImplA(double z)
        {
            const double n0 = -0.0005087819496582806;
            const double n1 = -0.008368748197417368;
            const double n2 = 0.03348066254097446;
            const double n3 = -0.012692614766297404;
            const double n4 = -0.03656379714117627;
            const double n5 = 0.02198786811111689;
            const double n6 = 0.008226878746769157;
            const double n7 = -0.005387729650712429;

            const double d0 = 1.0;
            const double d1 = -0.9700050433032906;
            const double d2 = -1.5657455823417585;
            const double d3 = 1.5622155839842302;
            const double d4 = 0.662328840472003;
            const double d5 = -0.7122890234154284;
            const double d6 = -0.05273963823400997;
            const double d7 = 0.07952836873415717;
            const double d8 = -0.0023339375937419;
            const double d9 = 0.0008862163904564247;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(n7,
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(
                                            FusedMultiplyAdd(
                                                FusedMultiplyAdd(d9,
                                                    z, d8),
                                                z, d7),
                                            z, d6),
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfInvImplB(double z)
        {
            const double n0 = -0.20243350835593876;
            const double n1 = 0.10526468069939171;
            const double n2 = 8.3705032834312;
            const double n3 = 17.644729840837403;
            const double n4 = -18.851064805871424;
            const double n5 = -44.6382324441787;
            const double n6 = 17.445385985570866;
            const double n7 = 21.12946554483405;
            const double n8 = -3.6719225470772936;

            const double d0 = 1.0;
            const double d1 = 6.242641248542475;
            const double d2 = 3.971343795334387;
            const double d3 = -28.66081804998;
            const double d4 = -20.14326346804852;
            const double d5 = 48.560921310873994;
            const double d6 = 10.826866735546016;
            const double d7 = -22.643693341313973;
            const double d8 = 1.7211476576120028;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(
                                            FusedMultiplyAdd(n8,
                                                z, n7),
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(
                                            FusedMultiplyAdd(d8,
                                                z, d7),
                                            z, d6),
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfInvImplC(double z)
        {
            const double n0 = -0.1311027816799519;
            const double n1 = -0.16379404719331705;
            const double n2 = 0.11703015634199525;
            const double n3 = 0.38707973897260434;
            const double n4 = 0.3377855389120359;
            const double n5 = 0.14286953440815717;
            const double n6 = 0.029015791000532906;
            const double n7 = 0.0021455899538880526;
            const double n8 = -6.794655751811263E-07;
            const double n9 = 2.8522533178221704E-08;
            const double n10 = -6.81149956853777E-10;

            const double d0 = 1.0;
            const double d1 = 3.4662540724256723;
            const double d2 = 5.381683457070069;
            const double d3 = 4.778465929458438;
            const double d4 = 2.5930192162362027;
            const double d5 = 0.848854343457902;
            const double d6 = 0.15226433829533179;
            const double d7 = 0.011059242293464892;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(
                                            FusedMultiplyAdd(
                                                FusedMultiplyAdd(
                                                    FusedMultiplyAdd(n10,
                                                        z, n9),
                                                    z, n8),
                                                z, n7),
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(d7,
                                            z, d6),
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfInvImplD(double z)
        {
            const double n0 = -0.0350353787183178;
            const double n1 = -0.0022242652921344794;
            const double n2 = 0.018557330651423107;
            const double n3 = 0.009508047013259196;
            const double n4 = 0.0018712349281955923;
            const double n5 = 0.00015754461742496055;
            const double n6 = 4.60469890584318E-06;
            const double n7 = -2.304047769118826E-10;
            const double n8 = 2.6633922742578204E-12;

            const double d0 = 1.0;
            const double d1 = 1.3653349817554064;
            const double d2 = 0.7620591645536234;
            const double d3 = 0.22009110576413124;
            const double d4 = 0.03415891436709477;
            const double d5 = 0.00263861676657016;
            const double d6 = 7.646752923027944E-05;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(
                                            FusedMultiplyAdd(n8,
                                                z, n7),
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(d6,
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfInvImplE(double z)
        {
            const double n0 = -0.016743100507663373;
            const double n1 = -0.0011295143874558028;
            const double n2 = 0.001056288621524929;
            const double n3 = 0.00020938631748758808;
            const double n4 = 1.4962478375834237E-05;
            const double n5 = 4.4969678992770644E-07;
            const double n6 = 4.625961635228786E-09;
            const double n7 = -2.811287356288318E-14;
            const double n8 = 9.905570997331033E-17;

            const double d0 = 1.0;
            const double d1 = 0.5914293448864175;
            const double d2 = 0.1381518657490833;
            const double d3 = 0.016074608709367652;
            const double d4 = 0.0009640118070051656;
            const double d5 = 2.7533547476472603E-05;
            const double d6 = 2.82243172016108E-07;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(
                                            FusedMultiplyAdd(n8,
                                                z, n7),
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(d6,
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfInvImplF(double z)
        {
            const double n0 = -0.002497821279189813;
            const double n1 = -7.79190719229054E-06;
            const double n2 = 2.5472303741302746E-05;
            const double n3 = 1.6239777734251093E-06;
            const double n4 = 3.963410113048012E-08;
            const double n5 = 4.116328311909442E-10;
            const double n6 = 1.4559628671867504E-12;
            const double n7 = -1.1676501239718427E-18;

            const double d0 = 1.0;
            const double d1 = 0.2071231122144225;
            const double d2 = 0.01694108381209759;
            const double d3 = 0.0006905382656226846;
            const double d4 = 1.4500735981823264E-05;
            const double d5 = 1.4443775662814415E-07;
            const double d6 = 5.097612765997785E-10;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(n7,
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(d6,
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static double ErfInvImplG(double z)
        {
            const double n0 = -0.0005390429110190785;
            const double n1 = -2.8398759004727723E-07;
            const double n2 = 8.994651148922914E-07;
            const double n3 = 2.2934585926592085E-08;
            const double n4 = 2.2556144486350015E-10;
            const double n5 = 9.478466275030226E-13;
            const double n6 = 1.3588013010892486E-15;
            const double n7 = -3.4889039339994887E-22;

            const double d0 = 1.0;
            const double d1 = 0.08457462340018994;
            const double d2 = 0.002820929847262647;
            const double d3 = 4.682929219408942E-05;
            const double d4 = 3.999688121938621E-07;
            const double d5 = 1.6180929088790448E-09;
            const double d6 = 2.315586083102596E-12;

            var n =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(
                                        FusedMultiplyAdd(n7,
                                            z, n6),
                                        z, n5),
                                    z, n4),
                                z, n3),
                            z, n2),
                        z, n1),
                    z, n0);
            var d =
                FusedMultiplyAdd(
                    FusedMultiplyAdd(
                        FusedMultiplyAdd(
                            FusedMultiplyAdd(
                                FusedMultiplyAdd(
                                    FusedMultiplyAdd(d6,
                                        z, d5),
                                    z, d4),
                                z, d3),
                            z, d2),
                        z, d1),
                    z, d0);
            return n / d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static double Erf(double z)
        {
            if (z < 0.0)
            {
                return -Erf(-z);
            }
            else if (z < 0.5)
            {
                return z >= 1E-10
                    ? z * 1.125 + z * ErfImplA(z)
                    : z * 1.125 + z * 0.0033791670955125737;
            }
            else if (z < 110.0)
            {
                var r = Exp(-z * z) / z;
                if (z < 0.75)
                {
                    return 1.0 - (r * ErfImplB(z - 0.50) + r * 0.3440242111682892);
                }
                else if (z < 1.25)
                {
                    return 1.0 - (r * ErfImplC(z - 0.75) + r * 0.4199909269809723);
                }
                else if (z < 2.25)
                {
                    return 1.0 - (r * ErfImplD(z - 1.25) + r * 0.48986250162124634);
                }
                else if (z < 3.50)
                {
                    return 1.0 - (r * ErfImplE(z - 2.25) + r * 0.5317370891571045);
                }
                else if (z < 5.25)
                {
                    return 1.0 - (r * ErfImplF(z - 3.50) + r * 0.5489973425865173);
                }
                else if (z < 8.00)
                {
                    return 1.0 - (r * ErfImplG(z - 5.25) + r * 0.5571740865707397);
                }
                else if (z < 11.5)
                {
                    return 1.0 - (r * ErfImplH(z - 8.00) + r * 0.5609807968139648);
                }
                else if (z < 17.0)
                {
                    return 1.0 - (r * ErfImplI(z - 11.5) + r * 0.5626493692398071);
                }
                else if (z < 24.0)
                {
                    return 1.0 - (r * ErfImplJ(z - 17.0) + r * 0.5634598135948181);
                }
                else if (z < 38.0)
                {
                    return 1.0 - (r * ErfImplK(z - 24.0) + r * 0.5638477802276611);
                }
                else if (z < 60.0)
                {
                    return 1.0 - (r * ErfImplL(z - 38.0) + r * 0.5640528202056885);
                }
                else if (z < 85.0)
                {
                    return 1.0 - (r * ErfImplM(z - 60.0) + r * 0.5641309022903442);
                }
                else
                {
                    return 1.0 - (r * ErfImplN(z - 85.0) + r * 0.5641584396362305);
                }
            }
            else
            {
                return double.IsNaN(z) ? double.NaN : 1.0;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static double ErfInv(double p)
        {
            if (p < 0)
            {
                return -ErfInv(-p);
            }
            else if (p <= 0.5)
            {
                var v = p * (p + 10.0);
                return v * 0.08913147449493408 + v * ErfInvImplA(p);
            }
            else if (p <= 0.75)
            {
                return Sqrt(-2.0 * Log(1 - p)) / (2.249481201171875 + ErfInvImplB(0.75 - p));
            }
            else if (p < 1.0)
            {
                var v = Sqrt(-Log(1 - p));
                if (v < 3.0)
                {
                    return 0.807220458984375 * v + ErfInvImplC(v - 1.125) * v;
                }
                else if (v < 6.0)
                {
                    return 0.9399557113647461 * v + ErfInvImplD(v - 3.0) * v;
                }
                else if (v < 18.0)
                {
                    return 0.9836282730102539 * v + ErfInvImplE(v - 6.0) * v;
                }
                else if (v < 44.0)
                {
                    return 0.9971456527709961 * v + ErfInvImplF(v - 18.0) * v;
                }
                else
                {
                    return 0.9994134902954102 * v + ErfInvImplG(v - 44.0) * v;
                }
            }
            else
            {
                return p == 1d ? double.PositiveInfinity : double.NaN;
            }
        }
    }

    public class Benchmarks
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static double RunOptimized(double x)
        {
            return OptimisedImplementation.Erf(x) + OptimisedImplementation.Erf(-x);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static double RunOriginal(double x)
        {
            return MathNet.Numerics.SpecialFunctions.Erf(x) + MathNet.Numerics.SpecialFunctions.Erf(-x);
        }

        [Benchmark]
        public double ErfOriginalAllBranchAverage()
            => RunOriginal(1e-11)
               + RunOriginal(0.4)
               + RunOriginal(0.6)
               + RunOriginal(0.8)
               + RunOriginal(1.3)
               + RunOriginal(3.0)
               + RunOriginal(5.0)
               + RunOriginal(7.0)
               + RunOriginal(10.0)
               + RunOriginal(16.0)
               + RunOriginal(23.0)
               + RunOriginal(35.0)
               + RunOriginal(58.0)
               + RunOriginal(80.0)
               + RunOriginal(110.0)
               + RunOriginal(120.0);

        [Benchmark]
        public double ErfOptimisedAllBranchAverage()
            => RunOriginal(1e-11)
               + RunOptimized(0.4)
               + RunOptimized(0.6)
               + RunOptimized(0.8)
               + RunOptimized(1.3)
               + RunOptimized(3.0)
               + RunOptimized(5.0)
               + RunOptimized(7.0)
               + RunOptimized(10.0)
               + RunOptimized(16.0)
               + RunOptimized(23.0)
               + RunOptimized(35.0)
               + RunOptimized(58.0)
               + RunOptimized(80.0)
               + RunOptimized(110.0)
               + RunOptimized(120.0);

        [Benchmark]
        public double ErfOriginalHotBranchAverage1()
            => RunOriginal(1e-11)
               + RunOriginal(0.4)
               + RunOriginal(0.6)
               + RunOriginal(0.8)
               + RunOriginal(1.3);

        [Benchmark]
        public double ErfOptimisedHotBranchAverage1()
            => RunOriginal(1e-11)
               + RunOptimized(0.4)
               + RunOptimized(0.6)
               + RunOptimized(0.8)
               + RunOptimized(1.3);

        [Benchmark]
        public double ErfOriginalHotBranchAverage2()
            => RunOriginal(1e-11)
               + RunOriginal(0.4);

        [Benchmark]
        public double ErfOptimisedHotBranchAverage2()
            => RunOriginal(1e-11)
               + RunOptimized(0.4);

        [Benchmark]
        public double OriginalErfInv()
        {
            var total = 0.0;
            for (var d = 0.0; d <= 1d; d += 0.01d)
            {
                total += MathNet.Numerics.SpecialFunctions.ErfInv(d);
                total += MathNet.Numerics.SpecialFunctions.ErfInv(-d);
            }

            return total;
        }

        [Benchmark]
        public double OptimisedErfInv()
        {
            var total = 0.0;
            for (var d = 0.0; d <= 1d; d += 0.01d)
            {
                total += OptimisedImplementation.ErfInv(d);
                total += OptimisedImplementation.ErfInv(-d);
            }

            return total;
        }
    }

    class Program
    {
        private static double BenchmarkErf(double x)
        {
            return (double)AdvancedDoubleDoubleMath.Erf(x);
        }

        private static unsafe void Compare(delegate*<double, double> left, delegate*<double, double> right, double inc)
        {
            var diff = 0d;
            var absDiff = 0d;
            var x = double.NaN;
            var expected = double.NaN;
            var actual = double.NaN;

            for (var i = inc; i < 1d; i += inc)
            {
                var a = left(i);
                var e = right(i);
                var d = a > e ? a - e : e - a;
                if (d > absDiff)
                {
                    absDiff = d;
                    x = i;
                    expected = e;
                    actual = a;
                }
            }

            Console.WriteLine($"max diff: {absDiff}");
            Console.WriteLine($"       x: {x}");
            Console.WriteLine($"  left y: {expected}");
            Console.WriteLine($" right y: {actual}");
        }


        public static unsafe void Main(string[] args)
        {
            Console.WriteLine("\nCompare Optimised to arbitrary precision error function");
            Compare(&OptimisedImplementation.Erf, &BenchmarkErf, ScaleB(1, -16));

            Console.WriteLine("\nCompare Optimised to mathnet error function");
            Compare(&OptimisedImplementation.Erf, &MathNet.Numerics.SpecialFunctions.Erf, ScaleB(1, -16));

            Console.WriteLine("\nCompare MathNet.Numerics to arbitrary precision error function");
            Compare(&MathNet.Numerics.SpecialFunctions.Erf, &BenchmarkErf, ScaleB(1, -16));

            Console.WriteLine("\nOptimised ErfInv vs mathnet ErfInv");
            Compare(&OptimisedImplementation.ErfInv, &MathNet.Numerics.SpecialFunctions.ErfInv, ScaleB(1, -16));
            
            Console.WriteLine("\nBenchmarks");
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
