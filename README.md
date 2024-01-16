# Задание 2

```
select p."Title" "Имя продукта", c."Title" "Имя категории"
from "Products" p 
left join "CategoriesProduct" cp on cp."ProductsId" = p."Id" 
left join "Categories" c on cp."CategoriesId" = c."Id";
```