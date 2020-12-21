import { Box, Flex, Heading, SimpleGrid } from "@chakra-ui/react";

const Customer = (props) => {
  let body = null;
  if (!props) {
    body = (
      <Box d="flex" justifyContent="center" justifyItems="center">
        Could not found any results.
      </Box>
    );
  }

  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      <Heading fontSize="xl" color="gray.700" textAlign="center" w="100%">
        {props.firstName}&nbsp;{props.lastName}
      </Heading>
      <SimpleGrid
        mt="3"
        w="100%"
        justifyContent="center"
        columns={1}
        spacing={5}
      >
        <Flex justifyContent="center">
          <Box color="gray.500">Address</Box>
          <Box ml="4">{props.address}</Box>
        </Flex>
        <Flex justifyContent="center">
          <Box color="gray.500">Phone</Box>
          <Box ml="4">{props.phone}</Box>
        </Flex>
        <Flex justifyContent="center">
          <Box color="gray.500">Start Date</Box>
          <Box ml="4">{new Date(props.startDate).toLocaleDateString()}</Box>
        </Flex>
      </SimpleGrid>
    </Flex>
  );
};

export async function getServerSideProps({ params }) {
  const res = await fetch(`http://localhost:5000/api/customers/${params.id}`);
  const data = await res.json();
  return { props: { ...data } };
}

export default Customer;
