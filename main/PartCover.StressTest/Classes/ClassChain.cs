using System;

namespace PartCover.StressTest.Classes
{
    public class Line001
    {
        public Line001 Derived()
        {
            var typeName = GetType().Name;
            var currentNumber = int.Parse(typeName.Substring(typeName.Length - 3));
            var nextNumber = (++currentNumber).ToString("000");
            var nextTypeName = "PartCover.StressTest.Classes." + typeName.Remove(typeName.Length - 3) + nextNumber;
            Console.Out.WriteLine("Running line " + nextNumber);
            return (Line001)Activator.CreateInstance(Type.GetType(nextTypeName));
        }

        public virtual void Foo() { Derived().Foo(); }
    }

    public class Line002 : Line001 { }
    public class Line003 : Line002 { }
    public class Line004 : Line003 { }
    public class Line005 : Line004 { }
    public class Line006 : Line005 { }
    public class Line007 : Line006 { }
    public class Line008 : Line007 { }
    public class Line009 : Line008 { }
    public class Line010 : Line009 { }
    public class Line011 : Line010 { }
    public class Line012 : Line011 { }
    public class Line013 : Line012 { }
    public class Line014 : Line013 { }
    public class Line015 : Line014 { }
    public class Line016 : Line015 { }
    public class Line017 : Line016 { }
    public class Line018 : Line017 { }
    public class Line019 : Line018 { }
    public class Line020 : Line019 { }
    public class Line021 : Line020 { }
    public class Line022 : Line021 { }
    public class Line023 : Line022 { }
    public class Line024 : Line023 { }
    public class Line025 : Line024 { }
    public class Line026 : Line025 { }
    public class Line027 : Line026 { }
    public class Line028 : Line027 { }
    public class Line029 : Line028 { }
    public class Line030 : Line029 { }
    public class Line031 : Line030 { }
    public class Line032 : Line031 { }
    public class Line033 : Line032 { }
    public class Line034 : Line033 { }
    public class Line035 : Line034 { }
    public class Line036 : Line035 { }
    public class Line037 : Line036 { }
    public class Line038 : Line037 { }
    public class Line039 : Line038 { }
    public class Line040 : Line039 { }
    public class Line041 : Line040 { }
    public class Line042 : Line041 { }
    public class Line043 : Line042 { }
    public class Line044 : Line043 { }
    public class Line045 : Line044 { }
    public class Line046 : Line045 { }
    public class Line047 : Line046 { }
    public class Line048 : Line047 { }
    public class Line049 : Line048 { }
    public class Line050 : Line049 { }
    public class Line051 : Line050 { }
    public class Line052 : Line051 { }
    public class Line053 : Line052 { }
    public class Line054 : Line053 { }
    public class Line055 : Line054 { }
    public class Line056 : Line055 { }
    public class Line057 : Line056 { }
    public class Line058 : Line057 { }
    public class Line059 : Line058 { }
    public class Line060 : Line059 { }
    public class Line061 : Line060 { }
    public class Line062 : Line061 { }
    public class Line063 : Line062 { }
    public class Line064 : Line063 { }
    public class Line065 : Line064 { }
    public class Line066 : Line065 { }
    public class Line067 : Line066 { }
    public class Line068 : Line067 { }
    public class Line069 : Line068 { }
    public class Line070 : Line069 { }
    public class Line071 : Line070 { }
    public class Line072 : Line071 { }
    public class Line073 : Line072 { }
    public class Line074 : Line073 { }
    public class Line075 : Line074 { }
    public class Line076 : Line075 { }
    public class Line077 : Line076 { }
    public class Line078 : Line077 { }
    public class Line079 : Line078 { }
    public class Line080 : Line079 { }
    public class Line081 : Line080 { }
    public class Line082 : Line081 { }
    public class Line083 : Line082 { }
    public class Line084 : Line083 { }
    public class Line085 : Line084 { }
    public class Line086 : Line085 { }
    public class Line087 : Line086 { }
    public class Line088 : Line087 { }
    public class Line089 : Line088 { }
    public class Line090 : Line089 { }
    public class Line091 : Line090 { }
    public class Line092 : Line091 { }
    public class Line093 : Line092 { }
    public class Line094 : Line093 { }
    public class Line095 : Line094 { }
    public class Line096 : Line095 { }
    public class Line097 : Line096 { }
    public class Line098 : Line097 { }
    public class Line099 : Line098 { }
    public class Line100 : Line099 { }
    public class Line101 : Line100 { }
    public class Line102 : Line101 { }
    public class Line103 : Line102 { }
    public class Line104 : Line103 { }
    public class Line105 : Line104 { }
    public class Line106 : Line105 { }
    public class Line107 : Line106 { }
    public class Line108 : Line107 { }
    public class Line109 : Line108 { }
    public class Line110 : Line109 { }
    public class Line111 : Line110 { }
    public class Line112 : Line111 { }
    public class Line113 : Line112 { }
    public class Line114 : Line113 { }
    public class Line115 : Line114 { }
    public class Line116 : Line115 { }
    public class Line117 : Line116 { }
    public class Line118 : Line117 { }
    public class Line119 : Line118 { }
    public class Line120 : Line119 { }
    public class Line121 : Line120 { }
    public class Line122 : Line121 { }
    public class Line123 : Line122 { }
    public class Line124 : Line123 { }
    public class Line125 : Line124 { }
    public class Line126 : Line125 { }
    public class Line127 : Line126 { }
    public class Line128 : Line127 { }
    public class Line129 : Line128 { }
    public class Line130 : Line129 { }
    public class Line131 : Line130 { }
    public class Line132 : Line131 { }
    public class Line133 : Line132 { }
    public class Line134 : Line133 { }
    public class Line135 : Line134 { }
    public class Line136 : Line135 { }
    public class Line137 : Line136 { }
    public class Line138 : Line137 { }
    public class Line139 : Line138 { }
    public class Line140 : Line139 { }
    public class Line141 : Line140 { }
    public class Line142 : Line141 { }
    public class Line143 : Line142 { }
    public class Line144 : Line143 { }
    public class Line145 : Line144 { }
    public class Line146 : Line145 { }
    public class Line147 : Line146 { }
    public class Line148 : Line147 { }
    public class Line149 : Line148 { }
    public class Line150 : Line149 { }
    public class Line151 : Line150 { }
    public class Line152 : Line151 { }
    public class Line153 : Line152 { }
    public class Line154 : Line153 { }
    public class Line155 : Line154 { }
    public class Line156 : Line155 { }
    public class Line157 : Line156 { }
    public class Line158 : Line157 { }
    public class Line159 : Line158 { }
    public class Line160 : Line159 { }
    public class Line161 : Line160 { }
    public class Line162 : Line161 { }
    public class Line163 : Line162 { }
    public class Line164 : Line163 { }
    public class Line165 : Line164 { }
    public class Line166 : Line165 { }
    public class Line167 : Line166 { }
    public class Line168 : Line167 { }
    public class Line169 : Line168 { }
    public class Line170 : Line169 { }
    public class Line171 : Line170 { }
    public class Line172 : Line171 { }
    public class Line173 : Line172 { }
    public class Line174 : Line173 { }
    public class Line175 : Line174 { }
    public class Line176 : Line175 { }
    public class Line177 : Line176 { }
    public class Line178 : Line177 { }
    public class Line179 : Line178 { }
    public class Line180 : Line179 { }
    public class Line181 : Line180 { }
    public class Line182 : Line181 { }
    public class Line183 : Line182 { }
    public class Line184 : Line183 { }
    public class Line185 : Line184 { }
    public class Line186 : Line185 { }
    public class Line187 : Line186 { }
    public class Line188 : Line187 { }
    public class Line189 : Line188 { }
    public class Line190 : Line189 { }
    public class Line191 : Line190 { }
    public class Line192 : Line191 { }
    public class Line193 : Line192 { }
    public class Line194 : Line193 { }
    public class Line195 : Line194 { }
    public class Line196 : Line195 { }
    public class Line197 : Line196 { }
    public class Line198 : Line197 { }
    public class Line199 : Line198 { }
    public class Line200 : Line199 { }
    public class Line201 : Line200 { }
    public class Line202 : Line201 { }
    public class Line203 : Line202 { }
    public class Line204 : Line203 { }
    public class Line205 : Line204 { }
    public class Line206 : Line205 { }
    public class Line207 : Line206 { }
    public class Line208 : Line207 { }
    public class Line209 : Line208 { }
    public class Line210 : Line209 { }
    public class Line211 : Line210 { }
    public class Line212 : Line211 { }
    public class Line213 : Line212 { }
    public class Line214 : Line213 { }
    public class Line215 : Line214 { }
    public class Line216 : Line215 { }
    public class Line217 : Line216 { }
    public class Line218 : Line217 { }
    public class Line219 : Line218 { }
    public class Line220 : Line219 { }
    public class Line221 : Line220 { }
    public class Line222 : Line221 { }
    public class Line223 : Line222 { }
    public class Line224 : Line223 { }
    public class Line225 : Line224 { }
    public class Line226 : Line225 { }
    public class Line227 : Line226 { }
    public class Line228 : Line227 { }
    public class Line229 : Line228 { }
    public class Line230 : Line229 { }
    public class Line231 : Line230 { }
    public class Line232 : Line231 { }
    public class Line233 : Line232 { }
    public class Line234 : Line233 { }
    public class Line235 : Line234 { }
    public class Line236 : Line235 { }
    public class Line237 : Line236 { }
    public class Line238 : Line237 { }
    public class Line239 : Line238 { }
    public class Line240 : Line239 { }
    public class Line241 : Line240 { }
    public class Line242 : Line241 { }
    public class Line243 : Line242 { }
    public class Line244 : Line243 { }
    public class Line245 : Line244 { }
    public class Line246 : Line245 { }
    public class Line247 : Line246 { }
    public class Line248 : Line247 { }
    public class Line249 : Line248 { }
    public class Line250 : Line249 { }
    public class Line251 : Line250 { }
    public class Line252 : Line251 { }
    public class Line253 : Line252 { }
    public class Line254 : Line253 { }
    public class Line255 : Line254 { }
    public class Line256 : Line255 { }
    public class Line257 : Line256 { }
    public class Line258 : Line257 { }
    public class Line259 : Line258 { }
    public class Line260 : Line259 { }
    public class Line261 : Line260 { }
    public class Line262 : Line261 { }
    public class Line263 : Line262 { }
    public class Line264 : Line263 { }
    public class Line265 : Line264 { }
    public class Line266 : Line265 { }
    public class Line267 : Line266 { }
    public class Line268 : Line267 { }
    public class Line269 : Line268 { }
    public class Line270 : Line269 { }
    public class Line271 : Line270 { }
    public class Line272 : Line271 { }
    public class Line273 : Line272 { }
    public class Line274 : Line273 { }
    public class Line275 : Line274 { }
    public class Line276 : Line275 { }
    public class Line277 : Line276 { }
    public class Line278 : Line277 { }
    public class Line279 : Line278 { }
    public class Line280 : Line279 { }
    public class Line281 : Line280 { }
    public class Line282 : Line281 { }
    public class Line283 : Line282 { }
    public class Line284 : Line283 { }
    public class Line285 : Line284 { }
    public class Line286 : Line285 { }
    public class Line287 : Line286 { }
    public class Line288 : Line287 { }
    public class Line289 : Line288 { }
    public class Line290 : Line289 { }
    public class Line291 : Line290 { }
    public class Line292 : Line291 { }
    public class Line293 : Line292 { }
    public class Line294 : Line293 { }
    public class Line295 : Line294 { }
    public class Line296 : Line295 { }
    public class Line297 : Line296 { }
    public class Line298 : Line297 { }
    public class Line299 : Line298 { }
    public class Line300 : Line299 { }
    public class Line301 : Line300 { }
    public class Line302 : Line301 { }
    public class Line303 : Line302 { }
    public class Line304 : Line303 { }
    public class Line305 : Line304 { }
    public class Line306 : Line305 { }
    public class Line307 : Line306 { }
    public class Line308 : Line307 { }
    public class Line309 : Line308 { }
    public class Line310 : Line309 { }
    public class Line311 : Line310 { }
    public class Line312 : Line311 { }
    public class Line313 : Line312 { }
    public class Line314 : Line313 { }
    public class Line315 : Line314 { }
    public class Line316 : Line315 { }
    public class Line317 : Line316 { }
    public class Line318 : Line317 { }
    public class Line319 : Line318 { }
    public class Line320 : Line319 { }
    public class Line321 : Line320 { }
    public class Line322 : Line321 { }
    public class Line323 : Line322 { }
    public class Line324 : Line323 { }
    public class Line325 : Line324 { }
    public class Line326 : Line325 { }
    public class Line327 : Line326 { }
    public class Line328 : Line327 { }
    public class Line329 : Line328 { }
    public class Line330 : Line329 { }
    public class Line331 : Line330 { }
    public class Line332 : Line331 { }
    public class Line333 : Line332 { }
    public class Line334 : Line333 { }
    public class Line335 : Line334 { }
    public class Line336 : Line335 { }
    public class Line337 : Line336 { }
    public class Line338 : Line337 { }
    public class Line339 : Line338 { }
    public class Line340 : Line339 { }
    public class Line341 : Line340 { }
    public class Line342 : Line341 { }
    public class Line343 : Line342 { }
    public class Line344 : Line343 { }
    public class Line345 : Line344 { }
    public class Line346 : Line345 { }
    public class Line347 : Line346 { }
    public class Line348 : Line347 { }
    public class Line349 : Line348 { }
    public class Line350 : Line349 { }
    public class Line351 : Line350 { }
    public class Line352 : Line351 { }
    public class Line353 : Line352 { }
    public class Line354 : Line353 { }
    public class Line355 : Line354 { }
    public class Line356 : Line355 { }
    public class Line357 : Line356 { }
    public class Line358 : Line357 { }
    public class Line359 : Line358 { }
    public class Line360 : Line359 { }
    public class Line361 : Line360 { }
    public class Line362 : Line361 { }
    public class Line363 : Line362 { }
    public class Line364 : Line363 { }
    public class Line365 : Line364 { }
    public class Line366 : Line365 { }
    public class Line367 : Line366 { }
    public class Line368 : Line367 { }
    public class Line369 : Line368 { }
    public class Line370 : Line369 { }
    public class Line371 : Line370 { }
    public class Line372 : Line371 { }
    public class Line373 : Line372 { }
    public class Line374 : Line373 { }
    public class Line375 : Line374 { }
    public class Line376 : Line375 { }
    public class Line377 : Line376 { }
    public class Line378 : Line377 { }
    public class Line379 : Line378 { }
    public class Line380 : Line379 { }
    public class Line381 : Line380 { }
    public class Line382 : Line381 { }
    public class Line383 : Line382 { }
    public class Line384 : Line383 { }
    public class Line385 : Line384 { }
    public class Line386 : Line385 { }
    public class Line387 : Line386 { }
    public class Line388 : Line387 { }
    public class Line389 : Line388 { }
    public class Line390 : Line389 { }
    public class Line391 : Line390 { }
    public class Line392 : Line391 { }
    public class Line393 : Line392 { }
    public class Line394 : Line393 { }
    public class Line395 : Line394 { }
    public class Line396 : Line395 { }
    public class Line397 : Line396 { }
    public class Line398 : Line397 { }
    public class Line399 : Line398 { }
    public class Line400 : Line399 { }
    public class Line401 : Line400 { }
    public class Line402 : Line401 { }
    public class Line403 : Line402 { }
    public class Line404 : Line403 { }
    public class Line405 : Line404 { }
    public class Line406 : Line405 { }
    public class Line407 : Line406 { }
    public class Line408 : Line407 { }
    public class Line409 : Line408 { }
    public class Line410 : Line409 { }
    public class Line411 : Line410 { }
    public class Line412 : Line411 { }
    public class Line413 : Line412 { }
    public class Line414 : Line413 { }
    public class Line415 : Line414 { }
    public class Line416 : Line415 { }
    public class Line417 : Line416 { }
    public class Line418 : Line417 { }
    public class Line419 : Line418 { }
    public class Line420 : Line419 { }
    public class Line421 : Line420 { }
    public class Line422 : Line421 { }
    public class Line423 : Line422 { }
    public class Line424 : Line423 { }
    public class Line425 : Line424 { }
    public class Line426 : Line425 { }
    public class Line427 : Line426 { }
    public class Line428 : Line427 { }
    public class Line429 : Line428 { }
    public class Line430 : Line429 { }
    public class Line431 : Line430 { }
    public class Line432 : Line431 { }
    public class Line433 : Line432 { }
    public class Line434 : Line433 { }
    public class Line435 : Line434 { }
    public class Line436 : Line435 { }
    public class Line437 : Line436 { }
    public class Line438 : Line437 { }
    public class Line439 : Line438 { }
    public class Line440 : Line439 { }
    public class Line441 : Line440 { }
    public class Line442 : Line441 { }
    public class Line443 : Line442 { }
    public class Line444 : Line443 { }
    public class Line445 : Line444 { }
    public class Line446 : Line445 { }
    public class Line447 : Line446 { }
    public class Line448 : Line447 { }
    public class Line449 : Line448 { }
    public class Line450 : Line449 { }
    public class Line451 : Line450 { }
    public class Line452 : Line451 { }
    public class Line453 : Line452 { }
    public class Line454 : Line453 { }
    public class Line455 : Line454 { }
    public class Line456 : Line455 { }
    public class Line457 : Line456 { }
    public class Line458 : Line457 { }
    public class Line459 : Line458 { }
    public class Line460 : Line459 { }
    public class Line461 : Line460 { }
    public class Line462 : Line461 { }
    public class Line463 : Line462 { }
    public class Line464 : Line463 { }
    public class Line465 : Line464 { }
    public class Line466 : Line465 { }
    public class Line467 : Line466 { }
    public class Line468 : Line467 { }
    public class Line469 : Line468 { }
    public class Line470 : Line469 { }
    public class Line471 : Line470 { }
    public class Line472 : Line471 { }
    public class Line473 : Line472 { }
    public class Line474 : Line473 { }
    public class Line475 : Line474 { }
    public class Line476 : Line475 { }
    public class Line477 : Line476 { }
    public class Line478 : Line477 { }
    public class Line479 : Line478 { }
    public class Line480 : Line479 { }
    public class Line481 : Line480 { }
    public class Line482 : Line481 { }
    public class Line483 : Line482 { }
    public class Line484 : Line483 { }
    public class Line485 : Line484 { }
    public class Line486 : Line485 { }
    public class Line487 : Line486 { }
    public class Line488 : Line487 { }
    public class Line489 : Line488 { }
    public class Line490 : Line489 { }
    public class Line491 : Line490 { }
    public class Line492 : Line491 { }
    public class Line493 : Line492 { }
    public class Line494 : Line493 { }
    public class Line495 : Line494 { }
    public class Line496 : Line495 { }
    public class Line497 : Line496 { }
    public class Line498 : Line497 { }
    public class Line499 : Line498 { }
    public class Line500 : Line499 { }
    public class Line501 : Line500 { }
    public class Line502 : Line501 { }
    public class Line503 : Line502 { }
    public class Line504 : Line503 { }
    public class Line505 : Line504 { }
    public class Line506 : Line505 { }
    public class Line507 : Line506 { }
    public class Line508 : Line507 { }
    public class Line509 : Line508 { }
    public class Line510 : Line509 { }
    public class Line511 : Line510 { }
    public class Line512 : Line511 { }
    public class Line513 : Line512 { }
    public class Line514 : Line513 { }
    public class Line515 : Line514 { }
    public class Line516 : Line515 { }
    public class Line517 : Line516 { }
    public class Line518 : Line517 { }
    public class Line519 : Line518 { }
    public class Line520 : Line519 { }
    public class Line521 : Line520 { }
    public class Line522 : Line521 { }
    public class Line523 : Line522 { }
    public class Line524 : Line523 { }
    public class Line525 : Line524 { }
    public class Line526 : Line525 { }
    public class Line527 : Line526 { }
    public class Line528 : Line527 { }
    public class Line529 : Line528 { }
    public class Line530 : Line529 { }
    public class Line531 : Line530 { }
    public class Line532 : Line531 { }
    public class Line533 : Line532 { }
    public class Line534 : Line533 { }
    public class Line535 : Line534 { }
    public class Line536 : Line535 { }
    public class Line537 : Line536 { }
    public class Line538 : Line537 { }
    public class Line539 : Line538 { }
    public class Line540 : Line539 { }
    public class Line541 : Line540 { }
    public class Line542 : Line541 { }
    public class Line543 : Line542 { }
    public class Line544 : Line543 { }
    public class Line545 : Line544 { }
    public class Line546 : Line545 { }
    public class Line547 : Line546 { }
    public class Line548 : Line547 { }
    public class Line549 : Line548 { }
    public class Line550 : Line549 { }
    public class Line551 : Line550 { }
    public class Line552 : Line551 { }
    public class Line553 : Line552 { }
    public class Line554 : Line553 { }
    public class Line555 : Line554 { }
    public class Line556 : Line555 { }
    public class Line557 : Line556 { }
    public class Line558 : Line557 { }
    public class Line559 : Line558 { }
    public class Line560 : Line559 { }
    public class Line561 : Line560 { }
    public class Line562 : Line561 { }
    public class Line563 : Line562 { }
    public class Line564 : Line563 { }
    public class Line565 : Line564 { }
    public class Line566 : Line565 { }
    public class Line567 : Line566 { }
    public class Line568 : Line567 { }
    public class Line569 : Line568 { }
    public class Line570 : Line569 { }
    public class Line571 : Line570 { }
    public class Line572 : Line571 { }
    public class Line573 : Line572 { }
    public class Line574 : Line573 { }
    public class Line575 : Line574 { }
    public class Line576 : Line575 { }
    public class Line577 : Line576 { }
    public class Line578 : Line577 { }
    public class Line579 : Line578 { }
    public class Line580 : Line579 { }
    public class Line581 : Line580 { }
    public class Line582 : Line581 { }
    public class Line583 : Line582 { }
    public class Line584 : Line583 { }
    public class Line585 : Line584 { }
    public class Line586 : Line585 { }
    public class Line587 : Line586 { }
    public class Line588 : Line587 { }
    public class Line589 : Line588 { }
    public class Line590 : Line589 { }
    public class Line591 : Line590 { }
    public class Line592 : Line591 { }
    public class Line593 : Line592 { }
    public class Line594 : Line593 { }
    public class Line595 : Line594 { }
    public class Line596 : Line595 { }
    public class Line597 : Line596 { }
    public class Line598 : Line597 { }
    public class Line599 : Line598 { }
    public class Line600 : Line599 { }
    public class Line601 : Line600 { }
    public class Line602 : Line601 { }
    public class Line603 : Line602 { }
    public class Line604 : Line603 { }
    public class Line605 : Line604 { }
    public class Line606 : Line605 { }
    public class Line607 : Line606 { }
    public class Line608 : Line607 { }
    public class Line609 : Line608 { }
    public class Line610 : Line609 { }
    public class Line611 : Line610 { }
    public class Line612 : Line611 { }
    public class Line613 : Line612 { }
    public class Line614 : Line613 { }
    public class Line615 : Line614 { }
    public class Line616 : Line615 { }
    public class Line617 : Line616 { }
    public class Line618 : Line617 { }
    public class Line619 : Line618 { }
    public class Line620 : Line619 { }
    public class Line621 : Line620 { }
    public class Line622 : Line621 { }
    public class Line623 : Line622 { }
    public class Line624 : Line623 { }
    public class Line625 : Line624 { }
    public class Line626 : Line625 { }
    public class Line627 : Line626 { }
    public class Line628 : Line627 { }
    public class Line629 : Line628 { }
    public class Line630 : Line629 { }
    public class Line631 : Line630 { }
    public class Line632 : Line631 { }
    public class Line633 : Line632 { }
    public class Line634 : Line633 { }
    public class Line635 : Line634 { }
    public class Line636 : Line635 { }
    public class Line637 : Line636 { }
    public class Line638 : Line637 { }
    public class Line639 : Line638 { }
    public class Line640 : Line639 { }
    public class Line641 : Line640 { }
    public class Line642 : Line641 { }
    public class Line643 : Line642 { }
    public class Line644 : Line643 { }
    public class Line645 : Line644 { }
    public class Line646 : Line645 { }
    public class Line647 : Line646 { }
    public class Line648 : Line647 { }
    public class Line649 : Line648 { }
    public class Line650 : Line649 { }
    public class Line651 : Line650 { }
    public class Line652 : Line651 { }
    public class Line653 : Line652 { }
    public class Line654 : Line653 { }
    public class Line655 : Line654 { }
    public class Line656 : Line655 { }
    public class Line657 : Line656 { }
    public class Line658 : Line657 { }
    public class Line659 : Line658 { }
    public class Line660 : Line659 { }
    public class Line661 : Line660 { }
    public class Line662 : Line661 { }
    public class Line663 : Line662 { }
    public class Line664 : Line663 { }
    public class Line665 : Line664 { }
    public class Line666 : Line665 { }
    public class Line667 : Line666 { }
    public class Line668 : Line667 { }
    public class Line669 : Line668 { }
    public class Line670 : Line669 { }
    public class Line671 : Line670 { }
    public class Line672 : Line671 { }
    public class Line673 : Line672 { }
    public class Line674 : Line673 { }
    public class Line675 : Line674 { }
    public class Line676 : Line675 { }
    public class Line677 : Line676 { }
    public class Line678 : Line677 { }
    public class Line679 : Line678 { }
    public class Line680 : Line679 { }
    public class Line681 : Line680 { }
    public class Line682 : Line681 { }
    public class Line683 : Line682 { }
    public class Line684 : Line683 { }
    public class Line685 : Line684 { }
    public class Line686 : Line685 { }
    public class Line687 : Line686 { }
    public class Line688 : Line687 { }
    public class Line689 : Line688 { }
    public class Line690 : Line689 { }
    public class Line691 : Line690 { }
    public class Line692 : Line691 { }
    public class Line693 : Line692 { }
    public class Line694 : Line693 { }
    public class Line695 : Line694 { }
    public class Line696 : Line695 { }
    public class Line697 : Line696 { }
    public class Line698 : Line697 { }
    public class Line699 : Line698 { }
    public class Line700 : Line699 { }
    public class Line701 : Line700 { }
    public class Line702 : Line701 { }
    public class Line703 : Line702 { }
    public class Line704 : Line703 { }
    public class Line705 : Line704 { }
    public class Line706 : Line705 { }
    public class Line707 : Line706 { }
    public class Line708 : Line707 { }
    public class Line709 : Line708 { }
    public class Line710 : Line709 { }
    public class Line711 : Line710 { }
    public class Line712 : Line711 { }
    public class Line713 : Line712 { }
    public class Line714 : Line713 { }
    public class Line715 : Line714 { }
    public class Line716 : Line715 { }
    public class Line717 : Line716 { }
    public class Line718 : Line717 { }
    public class Line719 : Line718 { }
    public class Line720 : Line719 { }
    public class Line721 : Line720 { }
    public class Line722 : Line721 { }
    public class Line723 : Line722 { }
    public class Line724 : Line723 { }
    public class Line725 : Line724 { }
    public class Line726 : Line725 { }
    public class Line727 : Line726 { }
    public class Line728 : Line727 { }
    public class Line729 : Line728 { }
    public class Line730 : Line729 { }
    public class Line731 : Line730 { }
    public class Line732 : Line731 { }
    public class Line733 : Line732 { }
    public class Line734 : Line733 { }
    public class Line735 : Line734 { }
    public class Line736 : Line735 { }
    public class Line737 : Line736 { }
    public class Line738 : Line737 { }
    public class Line739 : Line738 { }
    public class Line740 : Line739 { }
    public class Line741 : Line740 { }
    public class Line742 : Line741 { }
    public class Line743 : Line742 { }
    public class Line744 : Line743 { }
    public class Line745 : Line744 { }
    public class Line746 : Line745 { }
    public class Line747 : Line746 { }
    public class Line748 : Line747 { }
    public class Line749 : Line748 { }
    public class Line750 : Line749 { }
    public class Line751 : Line750 { }
    public class Line752 : Line751 { }
    public class Line753 : Line752 { }
    public class Line754 : Line753 { }
    public class Line755 : Line754 { }
    public class Line756 : Line755 { }
    public class Line757 : Line756 { }
    public class Line758 : Line757 { }
    public class Line759 : Line758 { }
    public class Line760 : Line759 { }
    public class Line761 : Line760 { }
    public class Line762 : Line761 { }
    public class Line763 : Line762 { }
    public class Line764 : Line763 { }
    public class Line765 : Line764 { }
    public class Line766 : Line765 { }
    public class Line767 : Line766 { }
    public class Line768 : Line767 { }
    public class Line769 : Line768 { }
    public class Line770 : Line769 { }
    public class Line771 : Line770 { }
    public class Line772 : Line771 { }
    public class Line773 : Line772 { }
    public class Line774 : Line773 { }
    public class Line775 : Line774 { }
    public class Line776 : Line775 { }
    public class Line777 : Line776 { }
    public class Line778 : Line777 { }
    public class Line779 : Line778 { }
    public class Line780 : Line779 { }
    public class Line781 : Line780 { }
    public class Line782 : Line781 { }
    public class Line783 : Line782 { }
    public class Line784 : Line783 { }
    public class Line785 : Line784 { }
    public class Line786 : Line785 { }
    public class Line787 : Line786 { }
    public class Line788 : Line787 { }
    public class Line789 : Line788 { }
    public class Line790 : Line789 { }
    public class Line791 : Line790 { }
    public class Line792 : Line791 { }
    public class Line793 : Line792 { }
    public class Line794 : Line793 { }
    public class Line795 : Line794 { }
    public class Line796 : Line795 { }
    public class Line797 : Line796 { }
    public class Line798 : Line797 { }
    public class Line799 : Line798 { }
    public class Line800 : Line799 { }
    public class Line801 : Line800 { }
    public class Line802 : Line801 { }
    public class Line803 : Line802 { }
    public class Line804 : Line803 { }
    public class Line805 : Line804 { }
    public class Line806 : Line805 { }
    public class Line807 : Line806 { }
    public class Line808 : Line807 { }
    public class Line809 : Line808 { }
    public class Line810 : Line809 { }
    public class Line811 : Line810 { }
    public class Line812 : Line811 { }
    public class Line813 : Line812 { }
    public class Line814 : Line813 { }
    public class Line815 : Line814 { }
    public class Line816 : Line815 { }
    public class Line817 : Line816 { }
    public class Line818 : Line817 { }
    public class Line819 : Line818 { }
    public class Line820 : Line819 { }
    public class Line821 : Line820 { }
    public class Line822 : Line821 { }
    public class Line823 : Line822 { }
    public class Line824 : Line823 { }
    public class Line825 : Line824 { }
    public class Line826 : Line825 { }
    public class Line827 : Line826 { }
    public class Line828 : Line827 { }
    public class Line829 : Line828 { }
    public class Line830 : Line829 { }
    public class Line831 : Line830 { }
    public class Line832 : Line831 { }
    public class Line833 : Line832 { }
    public class Line834 : Line833 { }
    public class Line835 : Line834 { }
    public class Line836 : Line835 { }
    public class Line837 : Line836 { }
    public class Line838 : Line837 { }
    public class Line839 : Line838 { }
    public class Line840 : Line839 { }
    public class Line841 : Line840 { }
    public class Line842 : Line841 { }
    public class Line843 : Line842 { }
    public class Line844 : Line843 { }
    public class Line845 : Line844 { }
    public class Line846 : Line845 { }
    public class Line847 : Line846 { }
    public class Line848 : Line847 { }
    public class Line849 : Line848 { }
    public class Line850 : Line849 { }
    public class Line851 : Line850 { }
    public class Line852 : Line851 { }
    public class Line853 : Line852 { }
    public class Line854 : Line853 { }
    public class Line855 : Line854 { }
    public class Line856 : Line855 { }
    public class Line857 : Line856 { }
    public class Line858 : Line857 { }
    public class Line859 : Line858 { }
    public class Line860 : Line859 { }
    public class Line861 : Line860 { }
    public class Line862 : Line861 { }
    public class Line863 : Line862 { }
    public class Line864 : Line863 { }
    public class Line865 : Line864 { }
    public class Line866 : Line865 { }
    public class Line867 : Line866 { }
    public class Line868 : Line867 { }
    public class Line869 : Line868 { }
    public class Line870 : Line869 { }
    public class Line871 : Line870 { }
    public class Line872 : Line871 { }
    public class Line873 : Line872 { }
    public class Line874 : Line873 { }
    public class Line875 : Line874 { }
    public class Line876 : Line875 { }
    public class Line877 : Line876 { }
    public class Line878 : Line877 { }
    public class Line879 : Line878 { }
    public class Line880 : Line879 { }
    public class Line881 : Line880 { }
    public class Line882 : Line881 { }
    public class Line883 : Line882 { }
    public class Line884 : Line883 { }
    public class Line885 : Line884 { }
    public class Line886 : Line885 { }
    public class Line887 : Line886 { }
    public class Line888 : Line887 { }
    public class Line889 : Line888 { }
    public class Line890 : Line889 { }
    public class Line891 : Line890 { }
    public class Line892 : Line891 { }
    public class Line893 : Line892 { }
    public class Line894 : Line893 { }
    public class Line895 : Line894 { }
    public class Line896 : Line895 { }
    public class Line897 : Line896 { }
    public class Line898 : Line897 { }
    public class Line899 : Line898 { }
    public class Line900 : Line899 { }
    public class Line901 : Line900 { }
    public class Line902 : Line901 { }
    public class Line903 : Line902 { }
    public class Line904 : Line903 { }
    public class Line905 : Line904 { }
    public class Line906 : Line905 { }
    public class Line907 : Line906 { }
    public class Line908 : Line907 { }
    public class Line909 : Line908 { }
    public class Line910 : Line909 { }
    public class Line911 : Line910 { }
    public class Line912 : Line911 { }
    public class Line913 : Line912 { }
    public class Line914 : Line913 { }
    public class Line915 : Line914 { }
    public class Line916 : Line915 { }
    public class Line917 : Line916 { }
    public class Line918 : Line917 { }
    public class Line919 : Line918 { }
    public class Line920 : Line919 { }
    public class Line921 : Line920 { }
    public class Line922 : Line921 { }
    public class Line923 : Line922 { }
    public class Line924 : Line923 { }
    public class Line925 : Line924 { }
    public class Line926 : Line925 { }
    public class Line927 : Line926 { }
    public class Line928 : Line927 { }
    public class Line929 : Line928 { }
    public class Line930 : Line929 { }
    public class Line931 : Line930 { }
    public class Line932 : Line931 { }
    public class Line933 : Line932 { }
    public class Line934 : Line933 { }
    public class Line935 : Line934 { }
    public class Line936 : Line935 { }
    public class Line937 : Line936 { }
    public class Line938 : Line937 { }
    public class Line939 : Line938 { }
    public class Line940 : Line939 { }
    public class Line941 : Line940 { }
    public class Line942 : Line941 { }
    public class Line943 : Line942 { }
    public class Line944 : Line943 { }
    public class Line945 : Line944 { }
    public class Line946 : Line945 { }
    public class Line947 : Line946 { }
    public class Line948 : Line947 { }
    public class Line949 : Line948 { }
    public class Line950 : Line949 { }
    public class Line951 : Line950 { }
    public class Line952 : Line951 { }
    public class Line953 : Line952 { }
    public class Line954 : Line953 { }
    public class Line955 : Line954 { }
    public class Line956 : Line955 { }
    public class Line957 : Line956 { }
    public class Line958 : Line957 { }
    public class Line959 : Line958 { }
    public class Line960 : Line959 { }
    public class Line961 : Line960 { }
    public class Line962 : Line961 { }
    public class Line963 : Line962 { }
    public class Line964 : Line963 { }
    public class Line965 : Line964 { }
    public class Line966 : Line965 { }
    public class Line967 : Line966 { }
    public class Line968 : Line967 { }
    public class Line969 : Line968 { }
    public class Line970 : Line969 { }
    public class Line971 : Line970 { }
    public class Line972 : Line971 { }
    public class Line973 : Line972 { }
    public class Line974 : Line973 { }
    public class Line975 : Line974 { }
    public class Line976 : Line975 { }
    public class Line977 : Line976 { }
    public class Line978 : Line977 { }
    public class Line979 : Line978 { }
    public class Line980 : Line979 { }
    public class Line981 : Line980 { }
    public class Line982 : Line981 { }
    public class Line983 : Line982 { }
    public class Line984 : Line983 { }
    public class Line985 : Line984 { }
    public class Line986 : Line985 { }
    public class Line987 : Line986 { }
    public class Line988 : Line987 { }
    public class Line989 : Line988 { }
    public class Line990 : Line989 { }
    public class Line991 : Line990 { }
    public class Line992 : Line991 { }
    public class Line993 : Line992 { }
    public class Line994 : Line993 { }
    public class Line995 : Line994 { }
    public class Line996 : Line995 { }
    public class Line997 : Line996 { }
    public class Line998 : Line997 { }

    public class Line999 : Line998 {
        public override void Foo() { }
    }
}