import { Box, Button, Flex, Heading, SimpleGrid } from "@chakra-ui/react";
import Link from "next/link";

const Product = (props) => {
  let body = null;
  if (!props) {
    body = (
      <Box d="flex" justifyContent="center" justifyItems="center">
        Could not found any products for this route.
      </Box>
    );
  }

  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      <Heading fontSize="xl" color="gray.700" textAlign="center" w="100%">
        {props.name}
      </Heading>
      <SimpleGrid
        mt="3"
        w="100%"
        justifyContent="center"
        columns={1}
        spacing={5}
      >
        <Flex justifyContent="center">
          <Box color="gray.500">Manufacturer</Box>
          <Box ml="4">{props.manufacturer}</Box>
        </Flex>
        <Flex justifyContent="center">
          <Box color="gray.500">Style</Box>
          <Box ml="4">{props.style}</Box>
        </Flex>
        <Flex justifyContent="center">
          <Box color="gray.500">Purchase Price</Box>
          <Box ml="4">${props.purchasePrice.toFixed(2)}</Box>
        </Flex>
        <Flex justifyContent="center">
          <Box color="gray.500">Sale Price</Box>
          <Box ml="4">${props.salePrice.toFixed(2)}</Box>
        </Flex>
        <Flex justifyContent="center">
          <Box color="gray.500">Quantity on Hand</Box>
          <Box ml="4">{props.quantityOnHand}</Box>
        </Flex>
        <Flex justifyContent="center">
          <Box color="gray.500">Commission Percentage</Box>
          <Box ml="4">{props.commissionPercentage.toFixed(2)}%</Box>
        </Flex>
        <Flex justifyContent="center">
          <Link href={`/product/edit/${props.productId}`}>
            <Button bgColor="teal.400" px={3} color="teal.900" type="submit">
              Edit
            </Button>
          </Link>
        </Flex>
      </SimpleGrid>
    </Flex>
  );
};

export async function getServerSideProps({ params }) {
  const res = await fetch(`http://localhost:5000/api/products/${params.id}`);
  const data = await res.json();
  return { props: { ...data } };
}

export default Product;
