create type general_category_enum as enum ('indoor', 'outdoor', 'medicinal');
create type specific_category_enum as enum ('maidenhair_fern', 'kentia_palm', 'snake_plant');

drop table if exists service cascade;
drop table if exists plant cascade;
drop table if exists planter cascade;

create table if not exists plant (
	id int primary key,
	name varchar(255) not null,
	image varchar(512) not null,
	price decimal(7,2) not null,
	description varchar(512) not null,
	general_category general_category_enum,
	specific_category specific_category_enum,
	isHotSale boolean
);

create table if not exists planter (
	id int primary key,
	name varchar(255) not null,
	image varchar(512) not null,
	price decimal(4,2) not null,
	description varchar(512) not null
);

create table service (
	id int primary key,
	name varchar(255) not null,
	image varchar(512) not null,
	price decimal(6,2) not null,
	description varchar(512) not null,
	general_category general_category_enum
);

-- Inserts --

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(0, '', '', 0, '', '', '', false);

INSERT INTO plant (id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(1, 'Philodendron Birkin', 'https://www.leafenvy.co.uk/cdn/shop/products/PhilodendronBirkinSmall.jpg?v=1681210388&width=920', 350, 'Variegated white line markings characterise this easy-going houseplant. ', 'indoor', 'snake_plant', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(2, 'Snake Plant Moonshine', 'https://www.leafenvy.co.uk/cdn/shop/products/Snake-Moonshine-M-Broadway-Sea-Spray.jpg?v=1675949003&width=920', 350, 'A snake plant that grows vertical silver, sturdy and striking leaves. ', 'indoor', 'snake_plant', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(3, 'Calathea Medallion', 'https://www.leafenvy.co.uk/cdn/shop/files/CalatheaMedallionMedium.jpg?v=1682701619&width=920', 350, 'Silver markings contrast against large emerald green decorative leaves.', 'indoor', 'kentia_palm', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(4, 'Calathea Orbifolia', 'https://www.leafenvy.co.uk/cdn/shop/files/CalatheaOrbifoliaMedium.jpg?v=1685957168&width=920', 350, 'A decorative air-purifying plant with uniquely striped & bright green, rounded leaves.', 'indoor', 'kentia_palm', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(5, 'Bird Of Paradise', 'https://www.leafenvy.co.uk/cdn/shop/products/BirdofParadiseLargeIndoorPlant.jpg?v=1680436849&width=920', 350, 'Iconic tropical houseplant famous for its large ribbed leaves. ', 'outdoor', 'maidenhair_fern', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(6, 'ZZ Plant', 'https://www.leafenvy.co.uk/cdn/shop/products/ZZPlantLargeIndoorPlant.jpg?v=1682703269&width=920', 350, 'Characterised by thick waxy leaves, this best-seller can handle low light and is easy to care for.', 'outdoor', 'maidenhair_fern', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(7, 'Monstera Deliciosa', 'https://www.leafenvy.co.uk/cdn/shop/products/MonsteraDeliciosaLarge.jpg?v=1682700135&width=920', 350, 'Legendary plant with iconic graphic leaves & an easy going nature.', 'outdoor', 'maidenhair_fern', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(8, 'Alocasia Zebrina', 'https://www.leafenvy.co.uk/cdn/shop/products/AlocasiaZebrina.jpg?v=1682683409&width=920', 350, 'With leaves shaped like elephant ears, this plant is certainly a show stopper.', 'medicinal', 'kentia_palm', false);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(9, 'Fiddle Leaf Fig', 'https://www.leafenvy.co.uk/cdn/shop/products/FiddleLeafFigSmall.jpg?v=1685617262&width=920', 350, 'Veined, glossy leaves characterise this striking houseplant.', 'medicinal', 'kentia_palm', false);

-- Hot Sale -- 

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(10, 'Golden Pothos', 'https://www.leafenvy.co.uk/cdn/shop/products/GoldenPothos.jpg?v=1681227865&width=920', 350, 'An easy-going fast grower, his yellow streaked leaves will trail downwards as he grows.', 'medicinal', 'kentia_palm', true);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(11, 'ZZ Black Raven', 'https://www.leafenvy.co.uk/cdn/shop/products/zz-raven-windor-sage-m.jpg?v=1676306266&width=920', 350, 'Thick, beautiful, waxy black leaves.', 'indoor', 'maidenhair_fern', true);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(12, 'Rubber Plant', 'https://www.leafenvy.co.uk/cdn/shop/products/RubberPlant_BroadwayCharcoalPot.jpg?v=1680434569&width=920', 350, 'A stunning houseplant plant with upright burgundy leaves.', 'indoor', 'maidenhair_fern', true);

INSERT INTO public.plant
(id, "name", image, price, description, general_category, specific_category, ishotsale)
VALUES(13, 'Boston Fern', 'https://www.leafenvy.co.uk/cdn/shop/products/BostonFernMedium_ChalkDalstonMedium.jpg?v=1680435155&width=920', 350, 'This a photogenic, pet-friendly and air-purifying plant that has been recommended by NASA.', 'indoor', 'maidenhair_fern', true);

-- Planters --

INSERT INTO public.planter
(id, "name", image, price, description)
VALUES(14, 'Broadway Sea Spray', 'https://www.leafenvy.co.uk/cdn/shop/products/BroadwaySeaSprayPlantPot.jpg?v=1680507604&width=920', 15, 'With smooth rounded edges, the Broadway is a simple yet elegant choice for any home interior coming in our sea spray colour way.');

INSERT INTO public.planter
(id, "name", image, price, description)
VALUES(15, 'Lurch Cream', 'https://www.leafenvy.co.uk/cdn/shop/files/LurchCreamPlantPot.jpg?v=1685616026&width=920', 15, 'A chic off-white ceramic pot with dark, uneven artistic lines.');

INSERT INTO public.planter
(id, "name", image, price, description)
VALUES(16, 'Broadway Chalk', 'https://www.leafenvy.co.uk/cdn/shop/products/BroadwayChalkPot.jpg?v=1680507188&width=920', 15, 'With smooth rounded edges, the Broadway is a simple yet elegant choice for any home interior.');

INSERT INTO public.planter
(id, "name", image, price, description)
VALUES(17, 'Windsor Sage', 'https://www.leafenvy.co.uk/cdn/shop/products/WindsorSageGreenPlantPot.jpg?v=1680509372&width=920', 15, 'With a crown-like base and regal form, our sage green Windsor planter comes in Sage green, a green-grey closely resembling dried sage leaves.');

-- Services --

INSERT INTO public.service
(id, "name", image, price, description, general_category)
VALUES(18, 'Landscape Gardening', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRADVUePLWNxFRnZsn575W2Fm0VMiDj37jd0w&usqp=CAU', 350, 'Whether it is growing your own food or setting 
up your roof-top garden, we provide the highest 
quality landscaping services, contributing to a greener world and substantial living!

Schedule your service appointment today!', 'outdoor');

INSERT INTO public.service
(id, "name", image, price, description, general_category)
VALUES(19, 'Planter Decorator', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmCxYByxpQOhBIhhWVNqPlBVsSbyWBXsD13w&usqp=CAU', 350, 'Whether it is growing your own food or setting 
up your roof-top garden, we provide the highest 
quality landscaping services, contributing to a greener world and substantial living!

Schedule your service appointment today!', 'indoor');





