import { Flex } from "@chakra-ui/react";
import Product from "../components/Product";
import TabularData from "../components/TabularData";

export default function Products({ data }) {
  return (
    // <TabularData
    //   caption={"Products"}
    //   headers={Object.getOwnPropertyNames(data[0])}
    //   values={data.map((x) => Object.values(x))}
    // />
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      {data.map((product) => (
        <Product key={product.productId} data={product} />
      ))}
    </Flex>
  );
}

Products.getInitialProps = async (ctx) => {
  const res = await fetch("http://localhost:5000/api/products");
  const data = await res.json();
  return { data };
};
