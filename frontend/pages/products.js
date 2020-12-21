import { Flex } from "@chakra-ui/react";
import Product from "../components/Product";
import TabularData from "../components/TabularData";

export default function Products({ data }) {
  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      {data.map((product) => (
        <Product key={product.productId} data={product} />
      ))}
    </Flex>
  );
}

Products.getInitialProps = async (ctx) => {
  const res = await fetch(`${process.env.apiBaseUrl}/products`);
  const data = await res.json();
  return { data };
};
